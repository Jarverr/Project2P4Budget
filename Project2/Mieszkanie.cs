using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class Mieszkanie
    {
        public Mieszkanie(int idMieszkania, double czynsz, double wodaKanalizacja, double prad, double ogrzewanie, double smieci, double konserwacjeNaprawy, double wyposazenie, double ubezpieczenieNieruchomosci, double inne, Budget budget)
        {
            IdMieszkania = idMieszkania;
            Czynsz = czynsz;
            WodaKanalizacja = wodaKanalizacja;
            Prad = prad;
            Ogrzewanie = ogrzewanie;
            Smieci = smieci;
            KonserwacjeNaprawy = konserwacjeNaprawy;
            Wyposazenie = wyposazenie;
            UbezpieczenieNieruchomosci = ubezpieczenieNieruchomosci;
            Inne = inne;
            Budget = budget;
        }

        [Key]
        [ForeignKey("Budget")]

        public int IdMieszkania { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double Czynsz { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double WodaKanalizacja { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double Prad { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double Ogrzewanie { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double Smieci { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double KonserwacjeNaprawy { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double Wyposazenie { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double UbezpieczenieNieruchomosci { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double Inne { get; set; }
        public virtual Budget Budget { get; set; }

    }
}
