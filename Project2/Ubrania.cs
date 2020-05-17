using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class Ubrania
    {
        public Ubrania(int idUbrania, double zwykleUbrania, double sportoweUbrania, double buty, double dodatki, double inne, Budget budget)
        {
            IdUbrania = idUbrania;
            ZwykleUbrania = zwykleUbrania;
            SportoweUbrania = sportoweUbrania;
            Buty = buty;
            Dodatki = dodatki;
            Inne = inne;
            Budget = budget;
        }

        [Key]
        [ForeignKey("Budget")]
        public int IdUbrania { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double ZwykleUbrania { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double SportoweUbrania { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double Buty { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double Dodatki { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double Inne { get; set; }
        public virtual Budget Budget { get; set; }

    }
}
