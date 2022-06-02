using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja_przemyslowa
{
    // *** WYLICZENIE MATERIAŁÓW ***
    public enum Material
    {
        stal_narzędziowa,
        stal_niskostopowa,
        aluminium,
        mosiądz,
        stop_magnezu
    }

    // *** KLASA PRODUKTU ***
    public class Produkt
    {
        public string nazwa;
        public Material material;
        public double masa_metalu;
        public string opis_szczeg;
        public double? wartosc;

        public Produkt(string nazwa, Material material, double masa_metalu, string opis_szczeg)
        {
            this.nazwa = nazwa;
            this.material = material;
            this.masa_metalu = masa_metalu;
            this.opis_szczeg = opis_szczeg;
            this.wartosc = this.masa_metalu * wartosc_materialu(this.material);
        }
        public Produkt(string dane)
        {
            string[] dane_podzielone = dane.Split(';'); //dekompozycja danych - podział na podciągi oddzielone średnikiem
            this.nazwa = dane_podzielone[0];
            this.material = toMaterial(dane_podzielone[1]);
            this.masa_metalu = Convert.ToDouble(dane_podzielone[2]);
            this.opis_szczeg = dane_podzielone[3];
            this.wartosc = Convert.ToDouble(dane_podzielone[4]);
        }

        public void Set_wartosc(double wartosc)
        {
            this.wartosc = wartosc;
        }

        public string Opis_produktu()
        {
            return nazwa + " - materiał: " + material + "; masa: " + masa_metalu + "; wartość wyrobu: " + wartosc + "; opis: " + opis_szczeg; ; //MASA METALU POTRZEBNA DO WYROBU A MASA PRZEDMIOTU
        }
   
        public override string ToString()
        {
            return nazwa + ";" + material + ";" + masa_metalu + ";" + opis_szczeg + ";" + wartosc;
        }

        private double wartosc_materialu(Material m) //wartość jednostki masy danego materiału
        {
            if (m == Material.stal_narzędziowa)
            {
                return 110.0;
            }
            else if (m == Material.stal_niskostopowa)
            {
                return 70.0;
            }
            else if (m == Material.stop_magnezu)
            {
                return 160.0;
            }
            else if (m == Material.aluminium)
            {
                return 30.0;
            }
            else if (m == Material.mosiądz)
            {
                return 120.0;
            }
            else return 0;
        }

        private Material toMaterial(string m) //konwersja łańcucha do typu Material
        {
            if (m == "stal_narzędziowa")
            {
                return Material.stal_narzędziowa;
            }
            else if (m == "stal_niskostopowa")
            {
                return Material.stal_niskostopowa;
            }
            else if (m == "stop_magnezu")
            {
                return Material.stop_magnezu;
            }
            else if (m == "aluminium")
            {
                return Material.aluminium;
            }
            else if (m == "mosiądz")
            {
                return Material.mosiądz;
            }
            else return Material.stal_niskostopowa;
        }
    }
}
