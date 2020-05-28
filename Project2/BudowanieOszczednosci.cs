using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class BudowanieOszczednosci
    {
        public BudowanieOszczednosci()
        {

        }
        public BudowanieOszczednosci(decimal funduszAwaryjny, decimal funduszWydatkówNieregularnych, decimal poduszkaFinansowa, decimal kontoEmerytalne, decimal nadpłataDlugow, decimal funduszWakacyjny, decimal funduszPrezentySwiateczne, decimal inne)
        {
            FunduszAwaryjny = funduszAwaryjny;
            FunduszWydatkówNieregularnych = funduszWydatkówNieregularnych;
            PoduszkaFinansowa = poduszkaFinansowa;
            KontoEmerytalne = kontoEmerytalne;
            NadpłataDlugow = nadpłataDlugow;
            FunduszWakacyjny = funduszWakacyjny;
            FunduszPrezentySwiateczne = funduszPrezentySwiateczne;
            Inne = inne;
        }

        public BudowanieOszczednosci(decimal funduszAwaryjny, decimal funduszWydatkówNieregularnych, decimal poduszkaFinansowa, decimal kontoEmerytalne, decimal nadpłataDlugow, decimal funduszWakacyjny, decimal funduszPrezentySwiateczne, decimal inne, Budget budget)
        {
            FunduszAwaryjny = funduszAwaryjny;
            FunduszWydatkówNieregularnych = funduszWydatkówNieregularnych;
            PoduszkaFinansowa = poduszkaFinansowa;
            KontoEmerytalne = kontoEmerytalne;
            NadpłataDlugow = nadpłataDlugow;
            FunduszWakacyjny = funduszWakacyjny;
            FunduszPrezentySwiateczne = funduszPrezentySwiateczne;
            Inne = inne;
            Budget = budget;
        }
        

        [Key]
        [ForeignKey("Budget")]
        public int IdBudowaniaOszczednosci { get; set; }
        //[Column(TypeName = "decimal(5,2)")]
        public decimal FunduszAwaryjny { get; set; }
        //[Column(TypeName = "decimal(5,2)")]
        public decimal FunduszWydatkówNieregularnych { get; set; }
        //[Column(TypeName = "decimal(5,2)")]
        public decimal PoduszkaFinansowa { get; set; }
        //[Column(TypeName = "decimal(5,2)")]
        public decimal KontoEmerytalne { get; set; }
        public decimal NadpłataDlugow { get; set; }
        public decimal FunduszWakacyjny { get; set; }
        public decimal FunduszPrezentySwiateczne { get; set; }
        public decimal Inne { get; set; }
        public virtual Budget Budget { get; set; }
    }
}
