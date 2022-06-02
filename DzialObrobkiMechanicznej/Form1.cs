using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using SuperSimpleTcp;

namespace DzialObrobkiMechanicznej
{
    public partial class Form1 : Form
    {
        // *** DANE: ***
        double ubytek_masy, czas_obrabiania; 
        const double cena_skrawania = 1.6; //cena za obrobienie 1 kg materiału powodując 1% ubytku masy
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

            txtUbytek.Text = trackUbytek.Value.ToString(); //początkowa wartość textBoxa
        }

        // *** PROCEDURY POŁĄCZENIA TCP/IP ***
        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            Produkt produkt = new Produkt($"{Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}");
            Produkty.Add(produkt);

            lstDoObrobki.Invoke(new Action(delegate ()
            {
                lstDoObrobki.Items.Add(Produkty[Produkty.Count - 1].Opis_produktu());
            }));
        }

        private void Events_Connected(object sender, ConnectionEventArgs e)
        {
            client.Send("Dzial obrobki"); //wysłanie komunikatu pozwalającego rozpoznać aplikację przez serwer
        }

        // *** PROCEDURY LOGIKI APLIKACJI ***
        private void btnSkrawaj_Click(object sender, EventArgs e) //rozpoczęcie obróbki skrawaniem
        {
            if (lstDoObrobki.SelectedItem != null)
            {
                var produkt = Produkty.Find(p => p.Opis_produktu() == lstDoObrobki.SelectedItem.ToString());
                Thread produkcja = new Thread(() => WatekProdukcji(produkt));
                produkcja.Start();
            }
        }
        private void WatekProdukcji(Produkt p)  
        {
            trackUbytek.Invoke(new Action(delegate ()
            {
                ubytek_masy = trackUbytek.Value;
            }));

            string opis_temp = p.Opis_produktu();
            p.wartosc += p.masa_metalu * ubytek_masy * cena_skrawania; //poszerzenie wartości wyrobu o koszt obróbki
            p.masa_metalu *= 1 - (ubytek_masy / 100); //pomniejszenie masy o ubytek
            czas_obrabiania = (p.masa_metalu/10 + ubytek_masy/10) * 1000;

            Thread.Sleep(Convert.ToInt32(czas_obrabiania));

            lstObrobione.Invoke(new Action(delegate ()
            {
                lstObrobione.Items.Add(p.Opis_produktu());
            }));

            client.Send(p.ToString());
            int index = lstDoObrobki.Items.IndexOf(opis_temp);

            lstDoObrobki.Invoke(new Action(delegate ()
            {
                lstDoObrobki.Items.RemoveAt(index);
            }));
        }

        private void trackUbytek_Scroll(object sender, EventArgs e)
        {
            txtUbytek.Text = trackUbytek.Value.ToString();

        }
    }
}
