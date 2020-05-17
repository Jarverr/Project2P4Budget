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
        public InneWydatki(int idInneWydatki, double dobroczynnosc, double prezenty, double rTVAGD, double oprogramowanie, double edukacjaSzkolenia, double uslugi, double podatki, double inne, Budget budget)
        {
            IdInneWydatki = idInneWydatki;
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
        [Column(TypeName = "decimal(5,2)")]

        public double Dobroczynnosc { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double Prezenty { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double RTVAGD { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double Oprogramowanie { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double EdukacjaSzkolenia { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double Uslugi { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double Podatki { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double Inne { get; set; }
        public virtual Budget Budget { get; set; }

    }
}
