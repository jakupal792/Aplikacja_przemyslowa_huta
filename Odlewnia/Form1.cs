using SuperSimpleTcp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Odlewnia
{
    public partial class Form1 : Form
    {
        // *** DANE: ***
        double temperatura_przetapiania, czas_przetapiania;
        const double cena_przetapiania = 6.4; //cena za podwyższenie temperatury 1 kg materiału o 1 stopień Celsjusza
        private static List<Produkt> Produkty = new List<Produkt>(); //lista produktów
        SimpleTcpClient client; //obiekt klienta

        // *** INICJALIZACJA OKNA ***
        private void Form1_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient("127.0.0.1:9000"); 
            client.Events.DataReceived += Events_DataReceived;
            client.Events.Connected += Events_Connected;

            try //połączenie z serwerem
            {
                client.Connect();
            }
            catch (Exception ex)
            { }
        }
        
        // *** PROCEDURA OKNA ***
        public Form1()
        {
            InitializeComponent();

            txtTemperatura.Text = trackTemperatura.Value.ToString(); //początkowa wartość textBoxa
        }

        // *** PROCEDURY POŁĄCZENIA TCP/IP ***
        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            Produkt produkt = new Produkt(($"{Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}"));
            Produkty.Add(produkt);

            lstDoPrzetopienia.Invoke(new Action(delegate ()
            {
                lstDoPrzetopienia.Items.Add(Produkty[Produkty.Count - 1].Opis_produktu());
            }));
        }

        private void Events_Connected(object sender, ConnectionEventArgs e)
        {
            client.Send("Odlewnia"); //wysłanie komunikatu pozwalającego rozpoznać aplikację przez serwer
        }

        // *** PROCEDURY LOGIKI APLIKACJI ***
        private void btnPrzetapiaj_Click(object sender, EventArgs e) //rozpoczęcie przetapiania
        {
            if (lstDoPrzetopienia.SelectedItem != null)
            {
                var produkt = Produkty.Find(p => p.Opis_produktu() == lstDoPrzetopienia.SelectedItem.ToString());
                Thread produkcja = new Thread(() => WatekProdukcji(produkt));
                produkcja.Start();
            }
        }

        private void WatekProdukcji(Produkt p)
        {
            trackTemperatura.Invoke(new Action(delegate ()
            {
                temperatura_przetapiania = trackTemperatura.Value;
            }));

            string opis_temp = p.Opis_produktu();
            p.wartosc += temperatura_przetapiania * p.masa_metalu * cena_przetapiania;  //poszerzenie wartości wyrobu o koszt przetopienia   
            czas_przetapiania = (p.masa_metalu / 10 + temperatura_przetapiania / 100) * 1000;
            Thread.Sleep(Convert.ToInt32(czas_przetapiania));

            lstPrzetopiono.Invoke(new Action(delegate ()
            {
                lstPrzetopiono.Items.Add(p.Opis_produktu());
            }));

            client.Send(p.ToString());
            int index = lstDoPrzetopienia.Items.IndexOf(opis_temp);

            lstDoPrzetopienia.Invoke(new Action(delegate ()
            {
                lstDoPrzetopienia.Items.RemoveAt(index);
            }));
        }

        private void trackTemperatura_Scroll(object sender, EventArgs e)
        {
            txtTemperatura.Text = trackTemperatura.Value.ToString();
        }
    }
}
