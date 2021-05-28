namespace MyShop.DataAccess.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDeliveryTypeToOrder : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Delivery", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "Delivery");
        }
    }
}
