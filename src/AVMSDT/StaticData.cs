using System;
using System.Collections.Generic;
using System.Text;

namespace AVMSDT
{
    public class StaticData
    {
        public static string MainFileExtension = ".avm";
        public static string DepartmentFileExtension = ".avd";

        public static string DefaultPassWord = "000000";

        public class UserLevelStrings
        {
            public const string UserLevelAdmin = "管理员";
            public const string UserLevelDepartment = "部门管理员";
            public const string UserLevelReadOnly = "只查看";
        }

        public class AnnualVacationData
        {
            public const int MonthPreYear = 12;
            public const int DaysPreYear = 365;
            public static int[] DaysPreMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        }

        public delegate void NoParamsDelegate();
        public delegate void OneStringParamDelegate(string one);
        public delegate bool OneStringParamBoolReturnDelegate(string one);
        public delegate void TwoStringParamDelegate(string one, string two);
    }
}
