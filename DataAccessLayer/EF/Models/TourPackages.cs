using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EF.Models
{
    public class TourPackages
    {
        [Key]
        public int TourPackageId { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        public double Cost { get; set; }

        // Foreign Key for Manager
        public int ManagerId { get; set; }

        // Navigation property for Manager
        public virtual Manager Manager { get; set; }
    }
}
