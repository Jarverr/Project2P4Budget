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
        public Rozrywka()
        {

        }
        public Rozrywka(decimal silowniaBasen, decimal kinoTeatr, decimal koncerty, decimal czasopisma, decimal ksiazki, decimal hobby, decimal hotel, decimal inne)
        {
            SilowniaBasen = silowniaBasen;
            KinoTeatr = kinoTeatr;
            Koncerty = koncerty;
            Czasopisma = czasopisma;
            Ksiazki = ksiazki;
            Hobby = hobby;
            Hotel = hotel;
            Inne = inne;
        }

        public Rozrywka( decimal silowniaBasen, decimal kinoTeatr, decimal koncerty, decimal czasopisma, decimal ksiazki, decimal hobby, decimal hotel, decimal inne, Budget budget)
        {
            //IdRozrywka = idRozrywka;
            SilowniaBasen = silowniaBasen;
            KinoTeatr = kinoTeatr;
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
        //[Column(TypeName = "decimal(5,2)")]

        public decimal SilowniaBasen { get; set; }
        public decimal KinoTeatr { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal Koncerty { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal Czasopisma { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal Ksiazki { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal Hobby { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal Hotel { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal Inne { get; set; }
        public virtual Budget Budget { get; set; }

    }
}
