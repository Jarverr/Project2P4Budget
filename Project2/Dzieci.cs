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
        public Dzieci(int idDzieci, double artykulySzkolne, double dodatkoweZajecia, double wplatyNaSzkole, double zabawkiGry, double opiekaNadDziecmi, double inne, Budget budget)
        {
            IdDzieci = idDzieci;
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
        [Column(TypeName = "decimal(5,2)")]

        public double ArtykulySzkolne { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double DodatkoweZajecia { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double WplatyNaSzkole { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double ZabawkiGry { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double OpiekaNadDziecmi { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double Inne { get; set; }
        public virtual Budget Budget { get; set; }

    }
}
