namespace dinnerOrder.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Dependencies : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "ApplicationUserId", c => c.Guid(nullable: false));
            AddColumn("dbo.Orders", "ApplicationUser_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Orders", "RestaurantId");
            CreateIndex("dbo.Orders", "ApplicationUser_Id");
            AddForeignKey("dbo.Orders", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Orders", "RestaurantId", "dbo.Restaurants", "RestaurantId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "RestaurantId", "dbo.Restaurants");
            DropForeignKey("dbo.Orders", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Orders", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Orders", new[] { "RestaurantId" });
            DropColumn("dbo.Orders", "ApplicationUser_Id");
            DropColumn("dbo.Orders", "ApplicationUserId");
        }
    }
}
