using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Company
{
    public class EmployeeDetails
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public int Seniority { get; set; }

        public DateTime? ConfirmationDate { get; set; }

        public int? JobStatusId { get; set; }

        public int? SectionId { get; set; }

        public int? DepartmentId { get; set; }

        public int? DesignationId { get; set; }

        public int? EmployeeCategoryId { get; set; }

        public int? AreaId { get; set; }

        public int? DivisionId { get; set; }

        public DateTime? TransferEDate { get; set; }

    }
}
