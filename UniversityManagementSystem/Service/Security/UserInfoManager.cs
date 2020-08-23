using Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Security;
using Utilities.Common;

namespace Service.Security
{
    public class UserInfoManager : BllCommon, IUserInfoManager
    {
        public ReturnMessage Delete(int id, int companyId)
        {
            throw new NotImplementedException();
        }

        public UserInfo Get(int id, int companyId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserInfo> GetAll(int companyId)
        {
            throw new NotImplementedException();
        }

        public ReturnMessage Save(UserInfo entity, AppSession appSession)
        {
            throw new NotImplementedException();
        }
    }
}
