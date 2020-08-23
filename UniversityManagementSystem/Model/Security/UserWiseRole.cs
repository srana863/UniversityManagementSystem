using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Security
{
    public class UserWiseRole
    {
        public int? UserRoleId { get; set; }

        public int? UserId { get; set; }

        public int? RoleId { get; set; }

        public bool? IsActive { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public int? UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }
}
