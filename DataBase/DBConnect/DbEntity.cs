using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DataBase.DBConnect;

namespace DataBase.DBConnect
{
    public partial class DbEntity : DbContext
    {
        //public DbEntity() : base("name=DBEntities"){}
        public virtual DbSet<Student> sysdiagrams { get; set; }
    }
}
