using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IBaseData<TEntity> where TEntity : class
    {
        void Salvar(TEntity obj);

        void Commit();
    }
}
