using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public abstract class BaseData<TEntity> : IDisposable,
       IBaseData<TEntity> where TEntity : class
    {
        Context contexto = new Context();

        public void Salvar(TEntity obj)
        {
            contexto.Set<TEntity>().Add(obj);
        }

        public void Commit()
        {
            contexto.SaveChanges();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }
    }
}
