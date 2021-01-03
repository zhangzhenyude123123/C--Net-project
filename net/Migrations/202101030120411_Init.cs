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
                        cid = c.Int(nullable: false, identity: true),
                        cname = c.String(),
                        mid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.cid);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        ssid = c.Int(nullable: false, identity: true),
                        sname = c.String(),
                        ssex = c.String(),
                        cid_cid = c.Int(),
                    })
                .PrimaryKey(t => t.ssid)
                .ForeignKey("dbo.Classes", t => t.cid_cid)
                .Index(t => t.cid_cid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "cid_cid", "dbo.Classes");
            DropIndex("dbo.Students", new[] { "cid_cid" });
            DropTable("dbo.Students");
            DropTable("dbo.Classes");
        }
    }
}
