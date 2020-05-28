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
        public Przychody()
        {

        }
        public Przychody(decimal wynagrodzenie, decimal wynagrodzeniePartnera, decimal premia, decimal przychodyZPremiiBankowych, decimal odsetkiBankowe, decimal sprzedazAllegro, decimal inne)
        {
            Wynagrodzenie = wynagrodzenie;
            WynagrodzeniePartnera = wynagrodzeniePartnera;
            Premia = premia;
            PrzychodyZPremiiBankowych = przychodyZPremiiBankowych;
            OdsetkiBankowe = odsetkiBankowe;
            SprzedazAllegro = sprzedazAllegro;
            Inne = inne;
        }

        public Przychody( decimal wynagrodzenie, decimal wynagrodzeniePartnera, decimal premia, decimal przychodyZPremiiBankowych, decimal odsetkiBankowe, decimal sprzedazAllegro, decimal inne, Budget budget)
        {
            //IdPrzychody = idPrzychody;
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
        //[Column(TypeName = "decimal(5,2)")]

        public decimal Wynagrodzenie { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal WynagrodzeniePartnera { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal Premia { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal PrzychodyZPremiiBankowych { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal OdsetkiBankowe { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal SprzedazAllegro { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal Inne { get; set; }
        public virtual Budget Budget { get; set; }

    }
}
