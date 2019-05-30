namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FYPRelationshipadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FYPs", "SupervisorID", c => c.Int(nullable: false));
            CreateIndex("dbo.FYPs", "SupervisorID");
            AddForeignKey("dbo.FYPs", "SupervisorID", "dbo.Supervisors", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FYPs", "SupervisorID", "dbo.Supervisors");
            DropIndex("dbo.FYPs", new[] { "SupervisorID" });
            DropColumn("dbo.FYPs", "SupervisorID");
        }
    }
}
