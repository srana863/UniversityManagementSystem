﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Common;

namespace Service.Common
{
    public class BllCommon
    {
        public DbContext _dbContext;
        public ReturnMessage _vmReturn;
        public BllCommon()
        {
            _vmReturn = new ReturnMessage();
            _dbContext = new DbContext(AppSetting.ConnectionString, "System.Data.SqlClient");
        }
    }
}
