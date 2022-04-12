using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SixthAttempt.Models
{
    [Table("Bidder")]
    public class Bidder
    {
        public Bidder()
        {
            this.croplists = new HashSet<CropList>();
            this.adminsBidders = new HashSet<Admin>();

        }
        [Key]
        [Required]
        public int bidderID { get; set; }
        [Required]
        [StringLength(12)]
        public string userName { get; set; }
        [StringLength(12)]
        [Required]
        [DataType("password")]
        public string password { get; set; }
        [Required]
        [StringLength(22)]
        public string fullName { get; set; }
        [Required]
        [StringLength(10)]
        public string mobileNumber { get; set; }
        [Required]
        [StringLength(12)]
        public string city { get; set; }
        [Required]
        [StringLength(15)]
        public string state { get; set; }
        [Required]
        [StringLength(12)]
        public string adharNumber { get; set; }
        [Required]
        [StringLength(8)]
        public string panNumber { get; set; }
        [Required]
        [StringLength(20)]

        public string bankName { get; set; }
        [Required]
        [StringLength(12)]

        public string accountNumber { get; set; }
         [Required]
        [StringLength(8)]

        public string IFSC { get; set; }

        public virtual ICollection<CropList> croplists { get; set; }
        public virtual ICollection<Admin> adminsBidders { get; set; }

    }
}