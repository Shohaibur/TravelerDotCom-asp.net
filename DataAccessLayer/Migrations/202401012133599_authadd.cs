namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class authadd : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Managers", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Managers", "Address", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Managers", "Address", c => c.String());
            AlterColumn("dbo.Managers", "Name", c => c.String());
        }
    }
}
