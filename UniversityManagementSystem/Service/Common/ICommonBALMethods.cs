using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Common;

namespace Service.Common
{
    public interface ICommonBALMethods<T> where T : class
    {
        ReturnMessage Save(T entity, AppSession appSession);
        ReturnMessage Delete(int id, int companyId);
        IEnumerable<T> GetAll(int companyId);
        T Get(int id, int companyId);
    }
}
