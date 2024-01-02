using DataAccessLayer.EF.Models;
using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repos
{
    internal class ManagerRepo : Repo, IRepo<Manager, string, Manager>, IAuth<bool>
    {
        public bool Authenticate(string username, string password)
        {
            var data = db.Managers.FirstOrDefault(m => m.Email.Equals(username) && m.Password.Equals(password));
            if (data != null)
            {
                return true;
            }
            return false;
        }
        public Manager Create(Manager obj)
        {
            db.Managers.Add(obj);
            if (db.SaveChanges() > 0)
                return obj;
            return null;
        }

        public bool Delete(string User_Id)
        {
            var ex = Get(User_Id);
            db.Managers.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Manager> Get()
        {
            return db.Managers.ToList();
        }

        public Manager Get(string Username)
        {
            return db.Managers.Find(Username);
        }

        public Manager Update(Manager obj)
        {
            var ex = Get(obj.Email);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0)
                return obj;

            return null;
        }
    }
}