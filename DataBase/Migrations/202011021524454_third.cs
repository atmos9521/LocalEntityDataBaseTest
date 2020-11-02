namespace DataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class third : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Student");
            AddColumn("dbo.Student", "StudentID", c => c.Int(nullable: false));
            AlterColumn("dbo.Student", "ID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Student", "ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Student");
            AlterColumn("dbo.Student", "ID", c => c.Int(nullable: false));
            DropColumn("dbo.Student", "StudentID");
            AddPrimaryKey("dbo.Student", "ID");
        }
    }
}
