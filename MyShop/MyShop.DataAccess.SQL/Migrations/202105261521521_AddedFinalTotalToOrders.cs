namespace MyShop.DataAccess.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedFinalTotalToOrders : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "FinalTotal", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "FinalTotal");
        }
    }
}
