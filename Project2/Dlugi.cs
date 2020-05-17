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
        public Dlugi(int idDlugi, double kredytHipoteczny, double kredytKonsumpcyjny, double pozyczkaOsobista, double inne, Budget budget)
        {
            IdDlugi = idDlugi;
            KredytHipoteczny = kredytHipoteczny;
            KredytKonsumpcyjny = kredytKonsumpcyjny;
            PozyczkaOsobista = pozyczkaOsobista;
            Inne = inne;
            Budget = budget;
        }

        [Key]
        [ForeignKey("Budget")]
        public int IdDlugi { get; set; }
        [Column(TypeName = "decimal(5,2)")]
        public double KredytHipoteczny { get; set; }
        [Column(TypeName = "decimal(5,2)")]
        public double KredytKonsumpcyjny { get; set; }
        [Column(TypeName = "decimal(5,2)")]
        public double PozyczkaOsobista { get; set; }
        [Column(TypeName = "decimal(5,2)")]
        public double Inne { get; set; }
        public virtual Budget Budget { get; set; }
    }
}
