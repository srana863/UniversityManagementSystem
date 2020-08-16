using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Enum
{
    public enum Month
    {
        January = 1,
        February = 2,
        March = 3,
        April = 4,
        May = 5,
        June = 6,
        July = 7,
        August = 8,
        Septembar = 9,
        October = 10,
        November = 11,
        December = 12
    }
    public enum MaritalStatus
    {
        Single = 1,
        Married = 2,
        Widowed = 3,
        Separated = 4,
        Divorced = 5
    }

    public enum Status
    {
        Reject = 0,
        Accept = 1
    }
    public enum UserRole
    {
        SuperAdmin = 1,
        Admin = 2,
        HOUser = 3,
        BranchUser = 4
    }
}
