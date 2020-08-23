using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Company
{
    public partial class CompanyInfo
    {
        public int CompanyId { get; set; }

        public string CompanyName { get; set; }

        public string CompanyEmail { get; set; }

        public string CompanyUrl { get; set; }

        public string CompanyAddress { get; set; }

        public string LogoUrl { get; set; }
        public bool IsActive { get; set; }
    }
}
