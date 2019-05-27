namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SupevisorModelUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Supervisors", "Projects", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Supervisors", "Projects");
        }
    }
}
