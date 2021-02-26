using System;
using System.Collections.Generic;
using System.Text;

namespace AVMSDT
{
    public class AVMSDialogStatic
    {
        public enum UserAddLevel
        {
            Read_Only,
            Department
        }

        public enum AddResult
        {
            Successful,
            Repetition,
            Failure
        }

        public delegate void NoParamsFunction();
        public delegate AddResult DepartmentAddFunction(string un, string upw, UserAddLevel level);
        public delegate void StringParamFunction(string str);
    }

    public class UserLoginData
    {
        public string UserName;
        public string UserPW;

        public UserLoginData()
        {
            UserName = "";
            UserPW = "";
        }
    }

    public class ObjectTransPackage
    {
        public object TransPackage;

        public ObjectTransPackage()
        {
            TransPackage = null;
        }
    }
    public class StringTransPackage
    {
        public string StringPackage;

        public StringTransPackage()
        {
            StringPackage = "";
        }
    }
}
