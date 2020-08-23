using Repository.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Security;
using Utilities.Common;
using QueryGenerator;
using Dapper;

namespace Repository.Security
{
    public class UserInfoRepository : DataCommon, IUserInfoRepository
    {
        public UserInfoRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Create(UserInfo model)
        {
            var query = CRUD<UserInfo>.Insert();
            return _dbContext._connection.Query<int>(query, model).Single();
        }

        public int Delete(int id, int companyId)
        {
            var query = CRUD<UserInfo>.Delete(o => o.UserId == o.UserId && o.CompanyId == o.CompanyId);
            return _dbContext._connection.Query<int>(query, new { UserId = id, CompanyId = companyId }).Single();
        }

        public UserInfo Get(int id, int companyId)
        {
            var query = CRUD<UserInfo>.Select(o => o.UserId == o.UserId && o.CompanyId == o.CompanyId);
            return _dbContext._connection.Query<UserInfo>(query, new { UserId = id, CompanyId = companyId }).FirstOrDefault();
        }

        public IEnumerable<UserInfo> GetAll(int companyId)
        {
            var query = CRUD<UserInfo>.Select(o => o.CompanyId == o.CompanyId);
            return _dbContext._connection.Query<UserInfo>(query, new { CompanyId = companyId });
        }

        public int Update(UserInfo model)
        {
            var query = CRUD<UserInfo>.Update(o => o.UserId == o.UserId && o.CompanyId == o.CompanyId);
            return _dbContext._connection.Query<int>(query, model).Single();
        }
    }
}
