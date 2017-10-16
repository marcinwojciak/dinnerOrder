namespace dinnerOrder.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FoodOrderId1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.FoodOrders");
            AddColumn("dbo.FoodOrders", "FoodOrderId", c => c.Guid(nullable: false, identity: true));
            AddPrimaryKey("dbo.FoodOrders", "FoodOrderId");
            DropColumn("dbo.FoodOrders", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FoodOrders", "Id", c => c.Guid(nullable: false, identity: true));
            DropPrimaryKey("dbo.FoodOrders");
            DropColumn("dbo.FoodOrders", "FoodOrderId");
            AddPrimaryKey("dbo.FoodOrders", "Id");
        }
    }
}
