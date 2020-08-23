using Model.Company;
using Model.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Common
{
    public interface ICompanyInfoRepository : ICommonDataMethods<CompanyInfo>
    {
        int Delete(int companyId);
        CompanyInfo Get(int id);
        IEnumerable<CompanyInfo> GetAll();
        IEnumerable<CompanyInfo> GetAll(bool isActive);
    }
    public interface IUserInfoRepository : ICommonDataMethods<UserInfo>
    {

    }
}
