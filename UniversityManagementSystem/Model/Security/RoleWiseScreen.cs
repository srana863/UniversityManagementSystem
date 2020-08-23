using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Security
{
    public class RoleWiseScreen
    {
        public int? Id { get; set; }

        public int? RoleId { get; set; }

        public int? ScreenId { get; set; }

        public bool? CanCreate { get; set; }

        public bool? CanUpdate { get; set; }

        public bool? CanDelete { get; set; }

        public bool? CanShowReport { get; set; }

        public string IsActive { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public int? UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }
}
