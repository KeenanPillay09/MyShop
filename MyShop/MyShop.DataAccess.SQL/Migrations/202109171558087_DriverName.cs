namespace MyShop.DataAccess.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DriverName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Drivers", "DriverName", c => c.String());
            DropColumn("dbo.Drivers", "FirstName");
            DropColumn("dbo.Drivers", "LastName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Drivers", "LastName", c => c.String());
            AddColumn("dbo.Drivers", "FirstName", c => c.String());
            DropColumn("dbo.Drivers", "DriverName");
        }
    }
}
