namespace Rocket_Admin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_StudentForeignKey : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Student", "CId", c => c.Int(nullable: false));
            CreateIndex("dbo.Student", "CId");
            AddForeignKey("dbo.Student", "CId", "dbo.Class", "Session", cascadeDelete: true);
            DropColumn("dbo.Student", "class");
            DropColumn("dbo.Student", "startDate");
            DropColumn("dbo.Student", "endDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Student", "endDate", c => c.DateTime());
            AddColumn("dbo.Student", "startDate", c => c.DateTime());
            AddColumn("dbo.Student", "class", c => c.Int());
            DropForeignKey("dbo.Student", "CId", "dbo.Class");
            DropIndex("dbo.Student", new[] { "CId" });
            DropColumn("dbo.Student", "CId");
        }
    }
}
