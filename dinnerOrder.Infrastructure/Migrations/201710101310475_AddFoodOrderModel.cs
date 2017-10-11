namespace dinnerOrder.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFoodOrderModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FoodOrders",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FoodName = c.String(),
                        RestaurantId = c.Guid(nullable: false),
                        ApplicationUserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUserId, cascadeDelete: true)
                .ForeignKey("dbo.Restaurants", t => t.RestaurantId, cascadeDelete: true)
                .Index(t => t.RestaurantId)
                .Index(t => t.ApplicationUserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FoodOrders", "RestaurantId", "dbo.Restaurants");
            DropForeignKey("dbo.FoodOrders", "ApplicationUserId", "dbo.AspNetUsers");
            DropIndex("dbo.FoodOrders", new[] { "ApplicationUserId" });
            DropIndex("dbo.FoodOrders", new[] { "RestaurantId" });
            DropTable("dbo.FoodOrders");
        }
    }
}
