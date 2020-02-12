namespace Rocket_Admin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Student", "presence", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Student", "presence", c => c.Boolean());
        }
    }
}
