using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Security
{
    public class UserInfo
    {
        public int UserId { get; set; }

        public string UserName { get; set; }

        public string EmailAddress { get; set; }

        public int? EmployeeId { get; set; }

        public int? CompanyId { get; set; }

        public bool IsActive { get; set; }

        public string Password { get; set; }

        public string PasswordSalt { get; set; }

        public bool? IsLockedOut { get; set; }

        public bool? IsAccountVerified { get; set; }

        public bool? ChangePassword { get; set; }

        public bool? IsPaymentMade { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public int? UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }
}
