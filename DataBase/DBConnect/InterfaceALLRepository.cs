using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.DBConnect
{
    interface InterfaceALLRepository<T>
    {
        T GetByID(int? ID);
        IEnumerable<T> GetAllData();
        void Create(T All);
        void Update(T All);
        void Delete(T All);
    }
}
