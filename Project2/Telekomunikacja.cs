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
        public Telekomunikacja(int idTelekomunikacja, double telefon1, double telefon2, double tv, double internet, double inne, Budget budget)
        {
            IdTelekomunikacja = idTelekomunikacja;
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
        [Column(TypeName = "decimal(5,2)")]

        public double Telefon1 { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double Telefon2 { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double Tv { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double Internet { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double Inne { get; set; }
        public virtual Budget Budget { get; set; }

    }
}
