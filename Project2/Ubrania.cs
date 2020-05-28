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
        public Ubrania()
        {

        }
        public Ubrania(decimal zwykleUbrania, decimal sportoweUbrania, decimal buty, decimal dodatki, decimal inne)
        {
            ZwykleUbrania = zwykleUbrania;
            SportoweUbrania = sportoweUbrania;
            Buty = buty;
            Dodatki = dodatki;
            Inne = inne;
        }

        public Ubrania( decimal zwykleUbrania, decimal sportoweUbrania, decimal buty, decimal dodatki, decimal inne, Budget budget)
        {
            //IdUbrania = idUbrania;
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
        //[Column(TypeName = "decimal(5,2)")]

        public decimal ZwykleUbrania { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal SportoweUbrania { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal Buty { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal Dodatki { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal Inne { get; set; }
        public virtual Budget Budget { get; set; }

    }
}
