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
        public Transport(int idTransport, double paliwoSamochod, double przegladNaprawa, double wyposazenie, double dodatkoweUbezp, double biletyKomunikacjiMiejskiej, double biletyPKPPKS, double taxi, double inne, Budget budget)
        {
            IdTransport = idTransport;
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
        [Column(TypeName = "decimal(5,2)")]

        public double PaliwoSamochod { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double PrzegladNaprawa { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double Wyposazenie { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double DodatkoweUbezp { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double BiletyKomunikacjiMiejskiej { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double BiletyPKPPKS { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double Taxi { get; set; }
        [Column(TypeName = "decimal(5,2)")]

        public double Inne { get; set; }
        public virtual Budget Budget { get; set; }

    }
}
