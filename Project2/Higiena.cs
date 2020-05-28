using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class Higiena
    {
        public Higiena()
        {

        }
        public Higiena(decimal kosmetyki, decimal srodkiCzystosci, decimal fryzjer, decimal kosmetyczka, decimal inne)
        {
            Kosmetyki = kosmetyki;
            SrodkiCzystosci = srodkiCzystosci;
            Fryzjer = fryzjer;
            Kosmetyczka = kosmetyczka;
            Inne = inne;
        }

        public Higiena( decimal kosmetyki, decimal srodkiCzystosci, decimal fryzjer, decimal kosmetyczka, decimal inne, Budget budget)
        {
            //IdHigiena = idHigiena;
            Kosmetyki = kosmetyki;
            SrodkiCzystosci = srodkiCzystosci;
            Fryzjer = fryzjer;
            Kosmetyczka = kosmetyczka;
            Inne = inne;
            Budget = budget;
        }

        [Key]
        [ForeignKey("Budget")]
        public int IdHigiena { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal Kosmetyki { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal SrodkiCzystosci { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal Fryzjer { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal Kosmetyczka { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal Inne { get; set; }
        public virtual Budget Budget { get; set; }

    }
}
