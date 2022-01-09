namespace Garage_MVC_WEB_API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TableCar : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OwnerName = c.String(),
                        CarNumber = c.String(),
                        CarStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cars");
        }
    }
}
