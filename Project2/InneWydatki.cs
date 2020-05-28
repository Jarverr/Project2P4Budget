using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class InneWydatki
    {
        public InneWydatki()
        {

        }
        public InneWydatki(decimal dobroczynnosc, decimal prezenty, decimal rTVAGD, decimal oprogramowanie, decimal edukacjaSzkolenia, decimal uslugi, decimal podatki, decimal inne)
        {
            Dobroczynnosc = dobroczynnosc;
            Prezenty = prezenty;
            RTVAGD = rTVAGD;
            Oprogramowanie = oprogramowanie;
            EdukacjaSzkolenia = edukacjaSzkolenia;
            Uslugi = uslugi;
            Podatki = podatki;
            Inne = inne;
        }

        public InneWydatki( decimal dobroczynnosc, decimal prezenty, decimal rTVAGD, decimal oprogramowanie, decimal edukacjaSzkolenia, decimal uslugi, decimal podatki, decimal inne, Budget budget)
        {
            //IdInneWydatki = idInneWydatki;
            Dobroczynnosc = dobroczynnosc;
            Prezenty = prezenty;
            RTVAGD = rTVAGD;
            Oprogramowanie = oprogramowanie;
            EdukacjaSzkolenia = edukacjaSzkolenia;
            Uslugi = uslugi;
            Podatki = podatki;
            Inne = inne;
            Budget = budget;
        }

        [Key]
        [ForeignKey("Budget")]
        public int IdInneWydatki { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal Dobroczynnosc { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal Prezenty { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal RTVAGD { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal Oprogramowanie { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal EdukacjaSzkolenia { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal Uslugi { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal Podatki { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal Inne { get; set; }
        public virtual Budget Budget { get; set; }

    }
}
