namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mngTp1tomany : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TourPackages", "Title", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TourPackages", "Title", c => c.String(nullable: false));
        }
    }
}
