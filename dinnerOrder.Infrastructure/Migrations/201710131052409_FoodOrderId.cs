namespace dinnerOrder.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FoodOrderId : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.FoodOrders");
            AlterColumn("dbo.FoodOrders", "Id", c => c.Guid(nullable: false, identity: true));
            AddPrimaryKey("dbo.FoodOrders", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.FoodOrders");
            AlterColumn("dbo.FoodOrders", "Id", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.FoodOrders", "Id");
        }
    }
}
