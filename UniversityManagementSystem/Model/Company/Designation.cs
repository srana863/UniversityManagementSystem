using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Company
{
    public class Designation
    {
        public int DesignationId { get; set; }

        public int? CompanyId { get; set; }

        public int? DesignationGroupId { get; set; }

        public string DesignationName { get; set; }

        public string DesignationNameBangla { get; set; }

        public string DesignationShortNameBangla { get; set; }

        public string DesignationShortName { get; set; }

        public string DesignationDescription { get; set; }

        public DateTime? DesignationDateFormed { get; set; }

        public int? DesignationPosition { get; set; }
    }
}
