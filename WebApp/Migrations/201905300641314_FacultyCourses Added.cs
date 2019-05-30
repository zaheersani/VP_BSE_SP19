namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FacultyCoursesAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.FacultyCourses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SupervisorID = c.Int(nullable: false),
                        CourseID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Courses", t => t.CourseID, cascadeDelete: true)
                .ForeignKey("dbo.Supervisors", t => t.SupervisorID, cascadeDelete: true)
                .Index(t => t.SupervisorID)
                .Index(t => t.CourseID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FacultyCourses", "SupervisorID", "dbo.Supervisors");
            DropForeignKey("dbo.FacultyCourses", "CourseID", "dbo.Courses");
            DropIndex("dbo.FacultyCourses", new[] { "CourseID" });
            DropIndex("dbo.FacultyCourses", new[] { "SupervisorID" });
            DropTable("dbo.FacultyCourses");
            DropTable("dbo.Courses");
        }
    }
}
