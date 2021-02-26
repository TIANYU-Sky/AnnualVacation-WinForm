using System;
using System.Collections.Generic;

namespace AVMSDT
{
    /// <summary>
    /// 用户操作等级
    /// </summary>
    public enum UserLevel
    {
        /// <summary>
        /// 无权限
        /// </summary>
        NO_ACCESS,
        /// <summary>
        /// 管理员权限
        /// </summary>
        ADMIN,
        /// <summary>
        /// 部门权限
        /// </summary>
        DEPARTMENT,
        /// <summary>
        /// 只读权限
        /// </summary>
        READ_ONLY
    }

    [Serializable]
    public class UserLoginInformation
    {
        public string UserPW;
        public UserLevel Level;
        public string Department;

        public UserLoginInformation()
        {
            UserPW = "";
            Level = UserLevel.NO_ACCESS;
            Department = "";
        }
    }

    [Serializable]
    public class InformationMainPackage
    {
        public Dictionary<string, KeyValuePair<string, bool>> DepartmentInfor;
        public Dictionary<string, UserLoginInformation> UsersLoginInfor;

        public InformationMainPackage()
        {
            DepartmentInfor = new Dictionary<string, KeyValuePair<string, bool>>();
            UsersLoginInfor = new Dictionary<string, UserLoginInformation>();
        }
    }

    [Serializable]
    public class EmployeePersonalInformation
    {
        /// <summary>
        /// 员工姓名
        /// </summary>
        public string Name;
        /// <summary>
        /// 员工英文名
        /// </summary>
        public string EnglishName;
        /// <summary>
        /// 员工入职时间
        /// </summary>
        public DateTime EntryTime;
        /// <summary>
        /// 员工所在的子部门
        /// </summary>
        public string SubDepartment;
        ///// <summary>
        ///// 员工上一年年假新增
        ///// </summary>
        //public double LastAdded;
        /// <summary>
        /// 员工上一年年假已休
        /// </summary>
        public int LastApplied;
        ///// <summary>
        ///// 员工本年度年假新增
        ///// </summary>
        //public double NewYearAdded;
        ///// <summary>
        ///// 员工本年度每月年假新增
        ///// </summary>
        //public double[] MonthAdded;
        ///// <summary>
        ///// 员工被延期的年假数
        ///// </summary>
        //public double Delay;
        ///// <summary>
        ///// 员工截至当月可申请的年假数
        ///// </summary>
        //public double Appliable;
        /// <summary>
        /// 员工今年已经申请的年假数
        /// </summary>
        public int Applied;
        ///// <summary>
        ///// 员工今年总共的休假数
        ///// </summary>
        //public double Total;
        ///// <summary>
        ///// 员工今年总共可申请的年假数
        ///// </summary>
        //public double TotalAppliable;
        /// <summary>
        /// 员工年假是否使用通用计算方式
        /// </summary>
        public bool AutoCalculate;
        /// <summary>
        /// 员工手动模式的年假固定时间
        /// </summary>
        public int ManualTime;

        public EmployeePersonalInformation()
        {
            Name = "";
            EnglishName = "";
            EntryTime = DateTime.MinValue;
            SubDepartment = "";
            //LastAdded = 0;
            LastApplied = 0;
            //NewYearAdded = 0;
            //MonthAdded = new double[12] { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 };
            //Delay = 0;
            //Appliable = 0;
            Applied = 0;
            //Total = 0;
            //TotalAppliable = 0;
            AutoCalculate = true;
        }
    }

    [Serializable]
    public class EmployeeInformation
    {
        public Dictionary<string, EmployeePersonalInformation> EmpolyeeInfor;

        public EmployeeInformation()
        {
            EmpolyeeInfor = new Dictionary<string, EmployeePersonalInformation>();
        }
    }
}
