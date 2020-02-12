namespace Rocket_Admin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Class",
                c => new
                    {
                        Session = c.Int(nullable: false),
                        startDate = c.DateTime(nullable: false),
                        endDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Session);
            
            CreateTable(
                "dbo.ORID_data",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        填寫時間 = c.DateTime(),
                        姓名 = c.String(maxLength: 50),
                        週一目標 = c.String(),
                        目標完成度 = c.String(),
                        心情 = c.String(),
                        學習歷程描述 = c.String(),
                        高峰低峰 = c.String(),
                        每日獲得 = c.String(),
                        明日行動 = c.String(),
                        週五填寫 = c.String(),
                        initdate = c.DateTime(),
                        Sid = c.Int(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        image = c.String(),
                        _class = c.Int(name: "class"),
                        startDate = c.DateTime(),
                        endDate = c.DateTime(),
                        exOccupation = c.String(),
                        futureOccupation = c.String(),
                        initDate = c.DateTime(),
                        firstMon = c.DateTime(),
                        presence = c.Boolean(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.week",
                c => new
                    {
                        week = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.week);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.week");
            DropTable("dbo.Student");
            DropTable("dbo.ORID_data");
            DropTable("dbo.Class");
        }
    }
}
