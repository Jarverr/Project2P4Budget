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
        public Mieszkanie()
        {

        }
        public Mieszkanie(decimal czynsz, decimal wodaKanalizacja, decimal prad, decimal gaz ,decimal ogrzewanie, decimal smieci, decimal konserwacjeNaprawy, decimal wyposazenie, decimal ubezpieczenieNieruchomosci, decimal inne)
        {
            Czynsz = czynsz;
            WodaKanalizacja = wodaKanalizacja;
            Prad = prad;
            Gaz = gaz;
            Ogrzewanie = ogrzewanie;
            Smieci = smieci;
            KonserwacjeNaprawy = konserwacjeNaprawy;
            Wyposazenie = wyposazenie;
            UbezpieczenieNieruchomosci = ubezpieczenieNieruchomosci;
            Inne = inne;
        }

        public Mieszkanie( decimal czynsz, decimal wodaKanalizacja, decimal prad, decimal gaz ,decimal ogrzewanie, decimal smieci, decimal konserwacjeNaprawy, decimal wyposazenie, decimal ubezpieczenieNieruchomosci, decimal inne, Budget budget)
        {
            //IdMieszkania = idMieszkania;
            Czynsz = czynsz;
            WodaKanalizacja = wodaKanalizacja;
            Prad = prad;
            Gaz = gaz;
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
        //[Column(TypeName = "decimal(5,2)")]

        public decimal Czynsz { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal WodaKanalizacja { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal Prad { get; set; }
        public decimal Gaz { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal Ogrzewanie { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal Smieci { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal KonserwacjeNaprawy { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal Wyposazenie { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal UbezpieczenieNieruchomosci { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal Inne { get; set; }
        public virtual Budget Budget { get; set; }

    }
}
