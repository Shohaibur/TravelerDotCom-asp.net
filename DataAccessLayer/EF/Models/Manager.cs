using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EF.Models
{
    public class Manager
    {
        [Key]
        public int ManagerId { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public int Mobile  { get; set; }

        public virtual ICollection<TourPackages> TourPackages { get; set; }
    }
}
