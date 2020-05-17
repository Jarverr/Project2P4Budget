using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class Rozrywka
    {
        public Rozrywka(int idRozrywka, double silowniaBasen, double koncerty, double czasopisma, double ksiazki, double hobby, double hotel, double inne, Budget budget)
        {
            IdRozrywka = idRozrywka;
            SilowniaBasen = silowniaBasen;
            Koncerty = koncerty;
            Czasopisma = czasopisma;
            Ksiazki = ksiazki;
            Hobby = hobby;
            Hotel = hotel;
            Inne = inne;
            Budget = budget;
        }

        [Key]
        [ForeignKey("Budget")]
        public int IdRozrywka { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double SilowniaBasen { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double Koncerty { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double Czasopisma { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double Ksiazki { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double Hobby { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double Hotel { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double Inne { get; set; }
        public virtual Budget Budget { get; set; }

    }
}
