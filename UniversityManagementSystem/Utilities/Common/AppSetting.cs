﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Common
{
    public class AppSetting
    {
        public static string ConnectionString { get; set; }
        public static int PasswordLenth { get; set; }
        public static string ServerName { get; set; }
        public static string DataBaseName { get; set; }
        public static string UserName { get; set; }
        public static string Password { get; set; }
        public static int DefaultTimeout { get; set; }
        public static string DatabaseProvider { get; set; }
        public static string UserSession { get; set; }
        public static string FromMail { get; set; }
        public const string TD_ERROR = "TD_ERROR";
        public const string TutorialFilePath = "~/TutorialFiles/";
        public const string AbsulateTutorialFilePath = "TutorialFiles/";

        public const string EmployeeImagePath = "~/Images/EmployeeImages/";
        public const string AbsulateEmployeeImagePath = "Images/EmployeeImages/";
        public const string ReportPath = "~/Report/CrystalReport/";
        public const string AbsulateReportPath = "Report/CrystalReport/";
    }
}
