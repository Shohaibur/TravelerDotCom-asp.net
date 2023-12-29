using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EF.Models
{
    public class Travelers
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Password { get; set; }
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public int PhoneNo { get; set; }

    }
}
