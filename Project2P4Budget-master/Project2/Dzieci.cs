using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class Dzieci
    {
        public Dzieci()
        {

        }
        public Dzieci(decimal artykulySzkolne, decimal dodatkoweZajecia, decimal wplatyNaSzkole, decimal zabawkiGry, decimal opiekaNadDziecmi, decimal inne)
        {
            ArtykulySzkolne = artykulySzkolne;
            DodatkoweZajecia = dodatkoweZajecia;
            WplatyNaSzkole = wplatyNaSzkole;
            ZabawkiGry = zabawkiGry;
            OpiekaNadDziecmi = opiekaNadDziecmi;
            Inne = inne;
        }

        public Dzieci( decimal artykulySzkolne, decimal dodatkoweZajecia, decimal wplatyNaSzkole, decimal zabawkiGry, decimal opiekaNadDziecmi, decimal inne, Budget budget)
        {
            //IdDzieci = idDzieci;
            ArtykulySzkolne = artykulySzkolne;
            DodatkoweZajecia = dodatkoweZajecia;
            WplatyNaSzkole = wplatyNaSzkole;
            ZabawkiGry = zabawkiGry;
            OpiekaNadDziecmi = opiekaNadDziecmi;
            Inne = inne;
            Budget = budget;
        }

        [Key]
        [ForeignKey("Budget")]
        public int IdDzieci { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal ArtykulySzkolne { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal DodatkoweZajecia { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal WplatyNaSzkole { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal ZabawkiGry { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal OpiekaNadDziecmi { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal Inne { get; set; }
        public virtual Budget Budget { get; set; }

    }
}
