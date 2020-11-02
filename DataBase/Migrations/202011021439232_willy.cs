namespace DataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class willy : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Students", newName: "Student");
            DropPrimaryKey("dbo.Student");
            AlterColumn("dbo.Student", "ID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Student", "ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Student");
            AlterColumn("dbo.Student", "ID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Student", "ID");
            RenameTable(name: "dbo.Student", newName: "Students");
        }
    }
}
