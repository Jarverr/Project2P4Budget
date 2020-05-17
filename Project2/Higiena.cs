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
        public Higiena(int idHigiena, double kosmetyki, double srodkiCzystosci, double fryzjer, double kosmetyczka, double inne, Budget budget)
        {
            IdHigiena = idHigiena;
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
        [Column(TypeName = "decimal(5,2)")]

        public double Kosmetyki { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double SrodkiCzystosci { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double Fryzjer { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double Kosmetyczka { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double Inne { get; set; }
        public virtual Budget Budget { get; set; }

    }
}
