namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NameisRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Supervisors", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Supervisors", "Name", c => c.String());
        }
    }
}
