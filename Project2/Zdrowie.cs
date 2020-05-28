using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class Zdrowie
    {
        public Zdrowie()
        {

        }
        public Zdrowie(decimal lekarz, decimal badania, decimal lekarstwa, decimal inne)
        {
            Lekarz = lekarz;
            Badania = badania;
            Lekarstwa = lekarstwa;
            Inne = inne;
        }

        public Zdrowie( decimal lekarz, decimal badania, decimal lekarstwa, decimal inne, Budget budget)
        {
            //IdZdrowie = idZdrowie;
            Lekarz = lekarz;
            Badania = badania;
            Lekarstwa = lekarstwa;
            Inne = inne;
            Budget = budget;
        }

        [Key]
        [ForeignKey("Budget")]
        public int IdZdrowie { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal Lekarz { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal Badania { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal Lekarstwa { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal Inne { get; set; }
        public virtual Budget Budget { get; set; }

    }
}
