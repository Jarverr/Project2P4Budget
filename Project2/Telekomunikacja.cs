using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class Telekomunikacja
    {
        public Telekomunikacja()
        {

        }
        public Telekomunikacja(decimal telefon1, decimal telefon2, decimal tv, decimal internet, decimal inne)
        {
            Telefon1 = telefon1;
            Telefon2 = telefon2;
            Tv = tv;
            Internet = internet;
            Inne = inne;
        }

        public Telekomunikacja(decimal telefon1, decimal telefon2, decimal tv, decimal internet, decimal inne, Budget budget)
        {
            //IdTelekomunikacja = idTelekomunikacja;
            Telefon1 = telefon1;
            Telefon2 = telefon2;
            Tv = tv;
            Internet = internet;
            Inne = inne;
            Budget = budget;
        }

        [Key]
        [ForeignKey("Budget")]
        public int IdTelekomunikacja { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal Telefon1 { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal Telefon2 { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal Tv { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal Internet { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal Inne { get; set; }
        public virtual Budget Budget { get; set; }

    }
}
