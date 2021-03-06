namespace MyShop.DataAccess.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedBasketTotalToOrders : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "BasketTotal", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "BasketTotal");
        }
    }
}
