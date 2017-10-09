namespace dinnerOrder.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class norestname : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Orders", "RestaurantsName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "RestaurantsName", c => c.String());
        }
    }
}
