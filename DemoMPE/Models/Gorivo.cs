using System.ComponentModel.DataAnnotations;

namespace DemoMPE.Models
{
    public class Gorivo
    {
        [Key]
        public int stevilka_vpisa { get; set; }

        public System.DateTime datum { get; set; }

        public System.DateTime ura_zacetnega_vpisa { get; set; }

        public System.DateTime ura_koncnega_vpisa { get; set; }

        public int zacetno_stanje { get; set; }

        public int koncno_stanje { get; set; }

        public float proizvedena_kolicina { get; set; }

        public int zacetno_stanje_cela { get; set; }

        public int zacetno_stanje_cifra { get; set; }

        public int koncno_stanje_cela { get; set; }

        public int koncno_stanje_cifra { get; set; }
    }
}