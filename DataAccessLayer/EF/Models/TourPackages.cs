using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EF.Models
{
    public class TourPackages
    {
        [Key]
        public int TourPackageId { get; set; }
        
        public string Title { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        public double Cost { get; set; }

        [ForeignKey("Manager")]
        public int ManagerId { get; set; }

       
        public virtual Manager Manager { get; set; }
    }
}
