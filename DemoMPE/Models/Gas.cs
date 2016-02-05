using System.ComponentModel.DataAnnotations;

namespace DemoMPE.Models
{
    public class Gas
    {
        [Key]
        public int stevilka_vpisa { get; set; }

        public System.DateTime datum { get; set; }

        public System.DateTime ura_zacetnega_vpisa { get; set; }

        public System.DateTime ura_koncnega_vpisa { get; set; }

        public decimal zacetno_stanje { get; set; }

        public decimal koncno_stanje { get; set; }

        public decimal proizvedena_kolicina { get; set; }

        public decimal zacetno_stanje_cela { get; set; }

        public decimal zacetno_stanje_cifra { get; set; }

        public decimal koncno_stanje_cela { get; set; }

        public decimal koncno_stanje_cifra { get; set; }
    }
}