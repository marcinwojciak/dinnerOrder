namespace dinnerOrder.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aspnetusers : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ApplicationUsers", newName: "AspNetUsers");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.AspNetUsers", newName: "ApplicationUsers");
        }
    }
}
