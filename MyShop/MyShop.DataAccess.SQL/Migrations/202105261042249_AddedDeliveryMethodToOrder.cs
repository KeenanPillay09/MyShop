namespace MyShop.DataAccess.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDeliveryMethodToOrder : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "DeliveryMethod", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "DeliveryMethod");
        }
    }
}
