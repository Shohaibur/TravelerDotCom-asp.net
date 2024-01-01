namespace DataAccessLayer.Migrations
{
    using DataAccessLayer.EF.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataAccessLayer.EF.TourDotComDbC>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataAccessLayer.EF.TourDotComDbC context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            var manager = new Manager
            {
                Email = "manager@example.com",
                Password = "SecurePassword123", // Please replace with a secure password
                Name = "John Doe",
                Address = "123 Main St",
                Mobile = 1234567890
            };

            context.Managers.AddOrUpdate(m => m.Email, manager);

            var tourPackages = new List<TourPackages>
            {
                new TourPackages { Title = "Package 1", Description = "Description 1", Duration = "1 week", Cost = 1000, ManagerId = manager.ManagerId },
                new TourPackages { Title = "Package 2", Description = "Description 2", Duration = "2 weeks", Cost = 2000, ManagerId = manager.ManagerId },
                new TourPackages { Title = "Package 3", Description = "Description 3", Duration = "3 weeks", Cost = 3000, ManagerId = manager.ManagerId },
                new TourPackages { Title = "Package 4", Description = "Description 4", Duration = "4 weeks", Cost = 4000, ManagerId = manager.ManagerId },
                new TourPackages { Title = "Package 5", Description = "Description 5", Duration = "5 weeks", Cost = 5000, ManagerId = manager.ManagerId }
            };

            context.TourPackages.AddOrUpdate(tp => tp.Title, tourPackages.ToArray());
        }
    }
}
