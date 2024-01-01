using DataAccessLayer.EF.Models;
using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repos
{
    internal class TourPackageRepo : Repo, IRepo<TourPackages,int,TourPackages>
    {
     public TourPackages Create(TourPackages obj)
        {
            db.TourPackages.Add(obj);
            if(db.SaveChanges() > 0)
            {
                return obj;
            }

            return null;
        }
        public bool Delete(int id)
        {
            var ex = Get(id);
            db.TourPackages.Remove(ex);
            return db.SaveChanges() > 0;
        }
        public List<TourPackages> Get()
        {
            return db.TourPackages.ToList();
        }
        public TourPackages Get(int id)
        {
            return db.TourPackages.Find(id);
        }

        public TourPackages Update(TourPackages obj)
        {
            var ex = Get(obj.TourPackageId);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0)
            return obj;
            return null;
        }
    }
}
