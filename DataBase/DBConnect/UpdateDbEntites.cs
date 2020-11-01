using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Data.Entity.Migrations.Model.UpdateDatabaseOperation;

namespace DataBase.DBConnect
{
    //using System.Data.Entity.Migrations;
    public partial class UpdateDbEntites : DbMigration
    {
        public override void Up()
        {
            Student studend_data = new Student();
            CreateTable(
                "Student",
                c => studend_data)
                .PrimaryKey(t => t.ID);
        }
        public override void Down()
        {
            DropTable("Student");
        }
    }
}
