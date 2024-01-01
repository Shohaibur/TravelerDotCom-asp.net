using DataAccessLayer.EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EF
{
    public class TourDotComDbC : DbContext
    {
        public DbSet<Manager>Managers { get; set; }
        public DbSet<Travelers>Travelers { get; set; }
        public DbSet<TourPackages>TourPackages  { get; set; }
        
    }
}
