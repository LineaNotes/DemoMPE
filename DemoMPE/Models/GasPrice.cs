using System.ComponentModel.DataAnnotations;

namespace DemoMPE.Models
{
    public class GasPrice
    {
        [Key]
        public int GasPriceId { get; set; }

        public System.DateTime gasDate { get; set; }

        public decimal gasPrice { get; set; }
    }
}