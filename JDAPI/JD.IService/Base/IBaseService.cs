using JD.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JD.IService.Base
{
    public interface IBaseService<T> where T : class
    {
        T GetById(int id);

        List<T> GetByIds();
    }
}
