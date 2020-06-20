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
        public Jedzenie()
        {

        }
        public Jedzenie(decimal jedzenieDom, decimal jedzenieMiasto, decimal jedzeniePraca, decimal alkohol, decimal inne)
        {
            JedzenieDom = jedzenieDom;
            JedzenieMiasto = jedzenieMiasto;
            JedzeniePraca = jedzeniePraca;
            Alkohol = alkohol;
            Inne = inne;
        }

        public Jedzenie( decimal jedzenieDom, decimal jedzenieMiasto, decimal jedzeniePraca, decimal alkohol, decimal inne, Budget budget)
        {
            //IdJedzenie = idJedzenie;
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
        //[Column(TypeName = "decimal(5,2)")]

        public decimal JedzenieDom { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal JedzenieMiasto { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal JedzeniePraca { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal Alkohol { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal Inne { get; set; }
        public virtual Budget Budget { get; set; }

    }
}
