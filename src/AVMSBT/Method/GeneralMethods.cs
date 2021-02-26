using System;
using System.Collections.Generic;
using System.Text;

namespace AVMSBT.Method
{
    public class GeneralMethods
    {
        public static int MathDoubleToInt(double data)
        {
            return (int)(data + 0.5);
        }
        public static string StructuredToString(DateTime date)
        {
            return date.ToString("yyyy-MM-dd");
        }
        public static string StructuredToString(double data)
        {
            return data.ToString("f2");
        }
    }
}
