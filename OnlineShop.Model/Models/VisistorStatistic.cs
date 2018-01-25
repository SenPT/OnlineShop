using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Model.Models
{

    [Table("VisitorStatistics")]
    public class VisitorStatistic
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public DateTime VistedDate { get; set; }

        [MaxLength(50)]
        public string IDAddress { get; set; }
    }
}
