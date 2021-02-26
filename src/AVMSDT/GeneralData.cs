using System;
using System.Collections.Generic;
using System.Text;

namespace AVMSDT
{
    public enum UserLoginState
    {
        Successful,
        None_User,
        Wrong_PW
    }


    public class DepartmentOperationData
    {
        public string FileID;
        public bool IsOpen;
        public bool SubDepartment;
        public Dictionary<string, EmployeePersonalInformation> Empolyees;

        public DepartmentOperationData()
        {
            FileID = "";
            IsOpen = false;
            Empolyees = new Dictionary<string, EmployeePersonalInformation>(); 
        }
    }

    public class CreateNewFile
    {
        public string FileName;
        public Dictionary<string, UserLoginInformation> UsersLoginInfor;

        public CreateNewFile()
        {
            FileName = "";
            UsersLoginInfor = new Dictionary<string, UserLoginInformation>();
        }
    }
}
