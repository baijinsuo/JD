using JD.Common;
using JD.Entity;
using JD.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JD.Service
{
    public class AbstractService<T> where T : BaseModel, new()
    {
        public virtual T GetById(int id)
        {
            if (id < 1)
                return null;

            T t = SqlHelper.Instance.SqlQueryable<T>($"select * from {typeof(T).Name} where Id={id}").First();
            if (t == null)
                return null;
            else
                return t;
        }

        public virtual List<T> GetByIds()
        {
            List<T> listT = SqlHelper.Instance.SqlQueryable<T>($"select * from {typeof(T).Name}").ToList();
            if (listT == null || listT.Count() < 1)
                return null;
            else
                return listT;
        }
    }
}
