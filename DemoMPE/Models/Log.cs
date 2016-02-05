using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMPE.Models
{
    public class Log
    {
        [Key]
        public int LogId { get; set; }

        public System.DateTime date { get; set; }

        //public string UserId { get; set; }
        //[ForeignKey("UserId")]
        //public ApplicationUser ApplicationUser { get; set; }
    }
}