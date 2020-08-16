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
        ReturnMessage Delete(int id, string identityCode);
        ReturnMessage Delete(string id, string identityCode);
        IEnumerable<T> GetAll(string identityCode);
        T Get(int id, string identityCode);
        T Get(string id, string identityCode);
    }
}
