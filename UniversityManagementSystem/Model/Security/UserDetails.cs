using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Security
{
    public class UserDetails
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public DateTime? LastLogInDate { get; set; }

        public DateTime? LastPasswordChangedDate { get; set; }

        public DateTime? LastLockOutDate { get; set; }

        public bool? IsLoggedIn { get; set; }

        public int? FailedPasswordAttemptCount { get; set; }

        public DateTime? FailedPasswordAttemptWindowStart { get; set; }

        public int? FailedPasswordAnswerAttemptCount { get; set; }

        public DateTime? FailedPasswordAswerAttemptWindowStart { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public int? UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }
}
