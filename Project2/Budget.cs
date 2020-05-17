using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class Budget
    {
        public Budget(int rok, int miesiąc)
        {
            Rok = rok;
            Miesiąc = miesiąc;
        }

        public Budget(int rok, int miesiąc, Jedzenie jedzenie, Przychody przychody, Transport transport, Mieszkanie mieszkanie, Telekomunikacja telekomunikacja, Zdrowie zdrowie, Ubrania ubrania, Higiena higiena, Dzieci dzieci, Rozrywka rozrywka, Dlugi dlugi, InneWydatki idInne)
        {
            Rok = rok;
            Miesiąc = miesiąc;
            Jedzenie = jedzenie;
            Przychody = przychody;
            Transport = transport;
            Mieszkanie = mieszkanie;
            Telekomunikacja = telekomunikacja;
            Zdrowie = zdrowie;
            Ubrania = ubrania;
            Higiena = higiena;
            Dzieci = dzieci;
            Rozrywka = rozrywka;
            Dlugi = dlugi;
            InneWydatki = idInne;
        }
        
        [Key]
        public int Rok  { get; set; }
        [Key]
        public int Miesiąc { get; set; }
        public virtual Jedzenie Jedzenie { get; set; }
        public virtual Przychody Przychody { get; set; }
        public virtual Transport Transport { get; set; }
        public virtual Mieszkanie Mieszkanie { get; set; }
        public virtual Telekomunikacja Telekomunikacja { get; set; }
        public virtual Zdrowie Zdrowie { get; set; }
        public virtual Ubrania Ubrania { get; set; }
        public virtual Higiena Higiena { get; set; }
        public virtual Dzieci Dzieci { get; set; }
        public virtual Rozrywka Rozrywka { get; set; }
        public virtual Dlugi Dlugi { get; set; }
        public virtual InneWydatki InneWydatki { get; set; }
    }
}
