﻿namespace DataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Student", "Filler1", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Student", "Filler1");
        }
    }
}
