using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.DBConnect
{
    public class AllRepository<T> : InterfaceALLRepository<T> where T : class
    {
        DbEntity DB = null;
        DbSet<T> DBset = null;

        public AllRepository()
        {
            DB = new DbEntity();
            DBset = DB.Set<T>();
        }

        public IEnumerable<T> GetAllData()
        {
            return DBset.ToList();
        }

        public void Create(T All)
        {
            DBset.Add(All);
            DB.SaveChanges();
        }

        public T GetByID(int? ID)
        {
            return DBset.Find(ID);
        }

        public void Update(T All)
        {
            DB.Entry(All).State = EntityState.Modified;
            DB.SaveChanges();
        }

        public void Delete(T All)
        {
            DBset.Remove(All);
            DB.SaveChanges();
        }

        public void Delete(int DataID)
        {
            DBset.Remove(GetByID(DataID));
            DB.SaveChanges();
        }

        //public bool UpdateTableSKIMA(string TableName)
        //{
        //    UpdateDbEntites mytest = new UpdateDbEntites();
        //    mytest.Down();
        //    mytest.Up();
            
        //    return Database.Delete(TableName);
        //}
        
    }
}
