using DataAccessLayer.EF.Models;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataAccessFactory
    {
       public static IRepo<TourPackages,int,TourPackages> TourPackagesData()
        {
            return new TourPackageRepo();
        }
        public static IAuth<bool> AuthData()
        {
            return new ManagerRepo();
        }
    }
}
