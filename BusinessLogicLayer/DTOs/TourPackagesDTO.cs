using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.DTOs
{
    public class TourPackagesDTO
    {
        public int TourPackageId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        public double Cost { get; set; }
        public int ManagerId { get; set; }
    }
}
