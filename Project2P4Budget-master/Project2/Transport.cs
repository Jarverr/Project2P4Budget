using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class Transport
    {
        public Transport()
        {

        }
        public Transport(decimal paliwoSamochod, decimal przegladNaprawa, decimal wyposazenie, decimal dodatkoweUbezp, decimal biletyKomunikacjiMiejskiej, decimal biletyPKPPKS, decimal taxi, decimal inne)
        {
            PaliwoSamochod = paliwoSamochod;
            PrzegladNaprawa = przegladNaprawa;
            Wyposazenie = wyposazenie;
            DodatkoweUbezp = dodatkoweUbezp;
            BiletyKomunikacjiMiejskiej = biletyKomunikacjiMiejskiej;
            BiletyPKPPKS = biletyPKPPKS;
            Taxi = taxi;
            Inne = inne;
        }

        public Transport( decimal paliwoSamochod, decimal przegladNaprawa, decimal wyposazenie, decimal dodatkoweUbezp, decimal biletyKomunikacjiMiejskiej, decimal biletyPKPPKS, decimal taxi, decimal inne, Budget budget)
        {
            //IdTransport = idTransport;
            PaliwoSamochod = paliwoSamochod;
            PrzegladNaprawa = przegladNaprawa;
            Wyposazenie = wyposazenie;
            DodatkoweUbezp = dodatkoweUbezp;
            BiletyKomunikacjiMiejskiej = biletyKomunikacjiMiejskiej;
            BiletyPKPPKS = biletyPKPPKS;
            Taxi = taxi;
            Inne = inne;
            Budget = budget;
        }

        [Key]
        [ForeignKey("Budget")]
        public int IdTransport { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal PaliwoSamochod { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal PrzegladNaprawa { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal Wyposazenie { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal DodatkoweUbezp { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal BiletyKomunikacjiMiejskiej { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal BiletyPKPPKS { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal Taxi { get; set; }
        //[Column(TypeName = "decimal(5,2)")]

        public decimal Inne { get; set; }
        public virtual Budget Budget { get; set; }

    }
}
