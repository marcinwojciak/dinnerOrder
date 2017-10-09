namespace dinnerOrder.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class neworderproperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "RestaurantsName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "RestaurantsName");
        }
    }
}
