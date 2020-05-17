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
        public Zdrowie(int idZdrowie, double lekarz, double badania, double lekarstwa, double inne, Budget budget)
        {
            IdZdrowie = idZdrowie;
            Lekarz = lekarz;
            Badania = badania;
            Lekarstwa = lekarstwa;
            Inne = inne;
            Budget = budget;
        }

        [Key]
        [ForeignKey("Budget")]
        public int IdZdrowie { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double Lekarz { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double Badania { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double Lekarstwa { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double Inne { get; set; }
        public virtual Budget Budget { get; set; }

    }
}
