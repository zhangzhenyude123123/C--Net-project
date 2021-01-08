namespace net.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        cid = c.Int(nullable: false),
                        cname = c.String(),
                        grade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.cid);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        ssid = c.Int(nullable: false),
                        sname = c.String(),
                        ssex = c.String(),
                        cid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ssid)
                .ForeignKey("dbo.Classes", t => t.cid, cascadeDelete: true)
                .Index(t => t.cid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "cid", "dbo.Classes");
            DropIndex("dbo.Students", new[] { "cid" });
            DropTable("dbo.Students");
            DropTable("dbo.Classes");
        }
    }
}
