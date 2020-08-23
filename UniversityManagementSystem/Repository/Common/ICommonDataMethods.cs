using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Common
{
    public interface ICommonDataMethods<TEntity>
    {
        int Create(TEntity model);
        int Update(TEntity model);
        int Delete(int id, int companyId);
        IEnumerable<TEntity> GetAll(int companyId);
        TEntity Get(int id, int companyId);
    }
}
