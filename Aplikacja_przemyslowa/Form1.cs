/* ----->
ROZWINIĘCIE:

-uswpólnienie klasy Produkt
<----- */

using SuperSimpleTcp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Aplikacja_przemyslowa
{
    public partial class Form1 : Form
    {
        // *** DANE: ***
        string gui_nazwa, gui_opis_szczeg, gui_material_str; //zmienne pobierane z GUI
        Material gui_material;
        double gui_masa;
        private static List<Produkt> Produkty = new List<Produkt>(); //lista wyrobów do produkcji
        private static List<Produkt> Wyprodukowane = new List<Produkt>(); //lista wyprodukowanych wyrobów
        SimpleTcpServer server; //obiekt serwera
        string odlewnia, dzial_obrobki; //adresy klientów

        // *** INICJALIZACJA OKNA ***
        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer("127.0.0.1:9000");
            server.Events.DataReceived += Events_ClientDataReceived;
            server.Start();
        }

        // *** PROCEDURA OKNA ***
        public Form1()
        {
            InitializeComponent();

            cmbMaterial.Items.Add("Stal narzędziowa"); //dodanie materiałów do comboBox'a
            cmbMaterial.Items.Add("Stal niskostopowa");
            cmbMaterial.Items.Add("Aluminium");
            cmbMaterial.Items.Add("Mosiądz");
            cmbMaterial.Items.Add("Stop magnezu");
            cmbMaterial.Text = "Stal narzędziowa";
        }


        // *** PROCEDURY POŁĄCZENIA TCP/IP ***
        private void Events_ClientDataReceived(object sender, SuperSimpleTcp.DataReceivedEventArgs e)
        {
            if ($"{Encoding.UTF8.GetString(e.Data)}" == "Odlewnia") //rozpoznanie klientów i przypisanie im łańcuchów przechowywujących ich adresów
            {
                odlewnia = e.IpPort;
            }
            else if ($"{Encoding.UTF8.GetString(e.Data)}" == "Dzial obrobki") // -||-
            {
                dzial_obrobki = e.IpPort;
            }
            else if (e.IpPort == odlewnia && dzial_obrobki != null) //wysyłanie danych otrzymanych z odlewni do działu obróbki
            {
                string odlany = $"{Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
                server.Send(dzial_obrobki, odlany);

            }
            else if (e.IpPort == dzial_obrobki) //wyświetlenie danych końcowych po otrzymaniu danych z działu obróbki
            {
                Wyprodukowane.Add(new Produkt($"{Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}"));
                lstWyprodukowano.Invoke(new Action(delegate ()
                {
                    lstWyprodukowano.Items.Add(Wyprodukowane[Wyprodukowane.Count - 1].Opis_produktu());
                }));
            }
        }

        // *** PROCEDURY LOGIKI APLIKACJI ***
        private Material Wybierz_material() //pobranie rodzaju materiału z GUI
        {
            gui_material_str = cmbMaterial.Text;

            if (gui_material_str == "Stal narzędziowa")
            {
                gui_material = Material.stal_narzędziowa;
            }
            else if (gui_material_str == "Stal niskostopowa")
            {
                gui_material = Material.stal_niskostopowa;
            }
            else if (gui_material_str == "Aluminium")
            {
                gui_material = Material.aluminium;
            }
            else if (gui_material_str == "Mosiądz")
            {
                gui_material = Material.mosiądz;
            }
            else if (gui_material_str == "Stop magnezu")
            {
                gui_material = Material.stop_magnezu;
            }

            return gui_material;
        }

        private void btnProdukt_Click(object sender, EventArgs e) //dodanie produktu do listy wyrobów 
        {
            gui_nazwa = txtNazwa.Text; //pobranie danych z GUI
            gui_material = Wybierz_material();
            gui_masa = double.Parse(txtMasa.Text);
            gui_opis_szczeg = txt_opis_szczeg.Text;

            if (!String.IsNullOrWhiteSpace(gui_nazwa) && gui_masa > 0.0 && unikalnosc_nazw(gui_nazwa))
            {
                Produkt produkt = new Produkt(gui_nazwa, gui_material, gui_masa, gui_opis_szczeg);
                Produkty.Add(produkt);
                lstDoWyprodukowania.Items.Add(Produkty[Produkty.Count - 1].Opis_produktu());
            }
        }

        private void btnProdukuj_Click(object sender, EventArgs e) //rozpoczęcie produkcji wyrobu
        {
            if (server.IsListening && lstDoWyprodukowania.SelectedItem != null)
            {
                string opis_temp = lstDoWyprodukowania.SelectedItem.ToString();
                int index = lstDoWyprodukowania.Items.IndexOf(opis_temp);
                var prod = Produkty.Find(p => p.Opis_produktu() == opis_temp);
                server.Send(odlewnia, prod.ToString());

                lstDoWyprodukowania.Invoke(new Action(delegate ()
                {
                    lstDoWyprodukowania.Items.RemoveAt(index);
                }));
            }
        }

        private bool unikalnosc_nazw(string nazwa)
        {
            foreach (Produkt p in Produkty)
            {
                if (p.nazwa == nazwa)
                {
                    return false; 
                }
            }
            return true;
        }
    }
}