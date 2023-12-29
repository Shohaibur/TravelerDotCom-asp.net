namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Managers",
                c => new
                    {
                        ManagerId = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Name = c.String(),
                        Address = c.String(),
                        Mobile = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ManagerId);
            
            CreateTable(
                "dbo.TourPackages",
                c => new
                    {
                        TourPackageId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Description = c.String(),
                        Duration = c.String(),
                        Cost = c.Double(nullable: false),
                        ManagerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TourPackageId)
                .ForeignKey("dbo.Managers", t => t.ManagerId, cascadeDelete: true)
                .Index(t => t.ManagerId);
            
            CreateTable(
                "dbo.Travelers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Password = c.String(nullable: false),
                        Name = c.String(),
                        Email = c.String(nullable: false),
                        PhoneNo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TourPackages", "ManagerId", "dbo.Managers");
            DropIndex("dbo.TourPackages", new[] { "ManagerId" });
            DropTable("dbo.Travelers");
            DropTable("dbo.TourPackages");
            DropTable("dbo.Managers");
        }
    }
}
