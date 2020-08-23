using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Company
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public int CompanyId { get; set; }

        public string EmployeeFirstName { get; set; }

        public string EmployeeLastName { get; set; }

        public string EmployeeMiddleName { get; set; }

        public string EmployeeFullName { get; set; }

        public string EmployeeFullNameBangla { get; set; }

        public string EmployeeSex { get; set; }

        public DateTime? EmployeeDOB { get; set; }

        public string EmployeeReligion { get; set; }

        public string EmployeeMaritalStatus { get; set; }

        public DateTime? EmployeeJoinDate { get; set; }

        public string EmployeeNationality { get; set; }

        public bool? DeptHeadYN { get; set; }

        public string EmployeeReference { get; set; }

        public string EmployeeNationalID { get; set; }

        public string EmployeeBloodGroup { get; set; }
    }
}
