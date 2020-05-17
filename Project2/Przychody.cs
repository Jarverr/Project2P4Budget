using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class Przychody
    {
        public Przychody(int idPrzychody, double wynagrodzenie, double wynagrodzeniePartnera, double premia, double przychodyZPremiiBankowych, double odsetkiBankowe, double sprzedazAllegro, double inne, Budget budget)
        {
            IdPrzychody = idPrzychody;
            Wynagrodzenie = wynagrodzenie;
            WynagrodzeniePartnera = wynagrodzeniePartnera;
            Premia = premia;
            PrzychodyZPremiiBankowych = przychodyZPremiiBankowych;
            OdsetkiBankowe = odsetkiBankowe;
            SprzedazAllegro = sprzedazAllegro;
            Inne = inne;
            Budget = budget;
        }

        [Key]
        [ForeignKey("Budget")]
        public int IdPrzychody { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double Wynagrodzenie { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double WynagrodzeniePartnera { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double Premia { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double PrzychodyZPremiiBankowych { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double OdsetkiBankowe { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double SprzedazAllegro { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double Inne { get; set; }
        public virtual Budget Budget { get; set; }

    }
}
