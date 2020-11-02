using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DataBase.DBConnect;

namespace DataBase.DBConnect
{
    public partial class DbEntity : DbContext
    {
        //製作重新更新EF檔案:Add-Migration
        //更新最新的EF資料庫:Update-Database
        //退至指定的版本:    Update-Database –TargetMigration:AddBlogUrl
        //(AddBlogUrl > 指定的版本)

        //public DbEntity() : base("name=DBEntities"){}
        public virtual DbSet<Student_old> sysdiagrams { get; set; }
        public virtual DbSet<CIF> CIF { get; set; }
    }
}