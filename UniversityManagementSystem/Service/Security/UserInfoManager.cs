using Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Security;
using Utilities.Common;
using System.Transactions;
using Repository.Common;
using Repository.Security;

namespace Service.Security
{
    public class UserInfoManager : BllCommon, IUserInfoManager
    {
        private readonly IUserInfoRepository _userInfoRepository;
        public UserInfoManager()
        {
            _userInfoRepository = new UserInfoRepository(_dbContext);
        }
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
            try
            {
                _dbContext.Open();
                return null;
            }
            catch (Exception e)
            {
                _dbContext.Close();
                return null;
            }
            finally
            {
                _dbContext.Close();
                _dbContext.Dispose();
            }
        }

        public ReturnMessage Save(UserInfo entity, AppSession appSession)
        {
            using (var transactionScope = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    _dbContext.Open();
                    return _vmReturn;
                }
                catch (Exception e)
                {
                    _dbContext.Close();
                    return _vmReturn;
                }
                finally
                {
                    _dbContext.Close();
                    _dbContext.Dispose();
                }
            }
        }
    }
}
