using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class Dlugi
    {
        public Dlugi()
        {

        }
        public Dlugi( decimal kredytHipoteczny, decimal kredytKonsumpcyjny, decimal pozyczkaOsobista, decimal inne, Budget budget)
        {
            KredytHipoteczny = kredytHipoteczny;
            KredytKonsumpcyjny = kredytKonsumpcyjny;
            PozyczkaOsobista = pozyczkaOsobista;
            Inne = inne;
            Budget = budget;
        }

        public Dlugi(decimal kredytHipoteczny, decimal kredytKonsumpcyjny, decimal pozyczkaOsobista, decimal inne)
        {
           
            KredytHipoteczny = kredytHipoteczny;
            KredytKonsumpcyjny = kredytKonsumpcyjny;
            PozyczkaOsobista = pozyczkaOsobista;
            Inne = inne;
        }

        [Key]
        [ForeignKey("Budget")]
        public int IdDlugi { get; set; }
        //[Column(TypeName = "decimal(5,2)")]
        public decimal KredytHipoteczny { get; set; }
        //[Column(TypeName = "decimal(5,2)")]
        public decimal KredytKonsumpcyjny { get; set; }
        //[Column(TypeName = "decimal(5,2)")]
        public decimal PozyczkaOsobista { get; set; }
        //[Column(TypeName = "decimal(5,2)")]
        public decimal Inne { get; set; }
        public virtual Budget Budget { get; set; }
    }
}
