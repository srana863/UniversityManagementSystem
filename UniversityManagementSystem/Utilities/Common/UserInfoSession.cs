using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Common
{
    public partial class UserInfoSession
    {
        public string UserId { get; set; }
        public string AccessLevel { get; set; }
        public string UserName { get; set; }
        public string UserFullName { get; set; }
        public string EmployeeID { get; set; }
        public string Password { get; set; }
        public Nullable<int> RoleId { get; set; }
        public int SelfServiceCategoryId { get; set; }
        public bool IsActive { get; set; }
        public bool IsLockedOut { get; set; }

        public string DesignationNameBangla { get; set; }
        public string EmployeeFullNameBangla { get; set; }

        //Employee
        public string IdentityCode { get; set; }
        public string EmployeeSex { get; set; }
        public Nullable<System.DateTime> EmployeeDOB { get; set; }
        public System.DateTime EmployeeJoinDate { get; set; }
        public string EmployeeNationality { get; set; }
        public string EmployeeBloodGroup { get; set; }


        //Employee Details
        public string PersonalEmail { get; set; }
        public string WorkEmail { get; set; }
        public string MobileNo { get; set; }


        //EmployeeStatus
        public string DesignationID { get; set; }
        public string AreaID { get; set; }
        public string DivisionID { get; set; }


        public string DesignationName { get; set; }
        public string AreaName { get; set; }
        public string DivisionName { get; set; }

        public string EmployeeImage { get; set; }
        public string ImageURL { get; set; }
    }
}
