using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class Jedzenie
    {
        public Jedzenie(int idJedzenie, double jedzenieDom, double jedzenieMiasto, double jedzeniePraca, double alkohol, double inne, Budget budget)
        {
            IdJedzenie = idJedzenie;
            JedzenieDom = jedzenieDom;
            JedzenieMiasto = jedzenieMiasto;
            JedzeniePraca = jedzeniePraca;
            Alkohol = alkohol;
            Inne = inne;
            Budget = budget;
        }

        [Key]
        [ForeignKey("Budget")]
        public int IdJedzenie { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double JedzenieDom { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double JedzenieMiasto { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double JedzeniePraca { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double Alkohol { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double Inne { get; set; }
        public virtual Budget Budget { get; set; }

    }
}
