using Repository.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Company;
using Utilities.Common;
using QueryGenerator;
using Dapper;

namespace Repository.Company
{
    public class CompanyInfoRepository : DataCommon, ICompanyInfoRepository
    {
        public CompanyInfoRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int Create(CompanyInfo model)
        {
            var query = CRUD<CompanyInfo>.Insert();
            return _dbContext._connection.Query<int>(query, model).Single();
        }
        public int Delete(int companyId)
        {
            var query = CRUD<CompanyInfo>.Delete(o => o.CompanyId == o.CompanyId);
            return _dbContext._connection.Query<int>(query, new { CompanyId = companyId }).Single();
        }
        public int Delete(int id, int companyId)
        {
            var query = CRUD<CompanyInfo>.Delete(o => o.CompanyId == o.CompanyId);
            return _dbContext._connection.Query<int>(query, new { CompanyId = id}).Single();
        }
        public CompanyInfo Get(int id)
        {
            var query = CRUD<CompanyInfo>.Select(o => o.CompanyId == o.CompanyId);
            return _dbContext._connection.Query<CompanyInfo>(query, new { CompanyId = id }).FirstOrDefault();
        }

        public CompanyInfo Get(int id, int companyId)
        {
            var query = CRUD<CompanyInfo>.Select(o => o.CompanyId == o.CompanyId);
            return _dbContext._connection.Query<CompanyInfo>(query, new { CompanyId = id }).FirstOrDefault();
        }
        public IEnumerable<CompanyInfo> GetAll(int companyId)
        {
            var query = CRUD<CompanyInfo>.Select();
            return _dbContext._connection.Query<CompanyInfo>(query).OrderBy(o => o.CompanyName);
        }
        public IEnumerable<CompanyInfo> GetAll()
        {
            var query = CRUD<CompanyInfo>.Select();
            return _dbContext._connection.Query<CompanyInfo>(query).OrderBy(o => o.CompanyName);
        }

        public IEnumerable<CompanyInfo> GetAll(bool isActive)
        {
            var query = CRUD<CompanyInfo>.Select(o => o.IsActive == o.IsActive);
            return _dbContext._connection.Query<CompanyInfo>(query, new { IsActive = isActive }).OrderBy(o => o.CompanyName);
        }

        public int Update(CompanyInfo model)
        {
            var query = CRUD<CompanyInfo>.Update(o => o.CompanyId == o.CompanyId);
            return _dbContext._connection.Query<int>(query, model).Single();
        }
    }
}
