using AVMSDT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 年假管理系统
{
    /// <summary>
    /// 程序操作数据包
    /// </summary>
    internal class OperationData
    {
        public static StaticData.NoParamsDelegate FileInitOperation = null;
        public static StaticData.NoParamsDelegate LoginStateChange;

        public static bool NeedSave;

        /// <summary>
        /// 当前用户
        /// </summary>
        public static string ActiveUser;
        /// <summary>
        /// 当前用户等级
        /// </summary>
        public static UserLevel ActiveLevel;
        /// <summary>
        /// 当前用户隶属部门（当等级为部门时使用）
        /// </summary>
        public static string UserDepartment;
        /// <summary>
        /// 用户登录数据
        /// </summary>
        public static Dictionary<string, UserLoginInformation> LoginData;
        /// <summary>
        /// 当前已选择的部门
        /// </summary>
        public static string SelectedDepartment;
        /// <summary>
        /// 当前文件项目名称
        /// </summary>
        public static string DirectoryName;
        /// <summary>
        /// 当前打开的文件路径（未打开时为空）
        /// </summary>
        //public static string FilePath;
        /// <summary>
        /// 当前打开文件的目录位置
        /// </summary>
        public static string FileDictionary;
        /// <summary>
        /// 当前数据是否保存至文件
        /// </summary>
        public static bool FileIsOpen;
        /// <summary>
        /// 当前的用户数据
        /// </summary>
        public static Dictionary<string, DepartmentOperationData> EmpolyeeData;

        public static string SelectedEmployeeNumber;
        public static EmployeePersonalInformation SelectedEmployeeInfo;
        public static double[] SelectedEmployeeMonthVac;
        public static double SelectedEmployeePreVac;
        public static double SelectedEmployeeCurrentVac;

        public static void Init()
        {
            ActiveUser = "";
            ActiveLevel = UserLevel.NO_ACCESS;
            UserDepartment = "";
            LoginData = new Dictionary<string, UserLoginInformation>();
            SelectedDepartment = "";
            DirectoryName = "";
            FileDictionary = "";
            FileIsOpen = false;
            EmpolyeeData = new Dictionary<string, DepartmentOperationData>();
            LoginStateChange = null;
            NeedSave = false;
            SelectedEmployeeNumber = "";
            SelectedEmployeeInfo = null;
            SelectedEmployeeMonthVac = new double[] { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 };
            SelectedEmployeePreVac = 0.0;
            SelectedEmployeeCurrentVac = 0.0;
        }
    }
}
