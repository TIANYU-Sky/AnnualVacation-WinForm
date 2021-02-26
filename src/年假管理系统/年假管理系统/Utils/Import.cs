using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 年假管理系统.Utils
{
    internal class Import
    {
        private ApplicationClass ApplicationClass;
        private Workbook Workbook;

        public Import(string path)
        {
            ApplicationClass = new ApplicationClass();
            Workbook = ApplicationClass.Workbooks.Open(path);
        }

        public bool ImportData()
        {
            bool result = true;
            for (int i = 1; i <= Workbook.Sheets.Count; ++i)
            {
                Worksheet worksheet = (Worksheet)Workbook.Sheets[i];
                int jobnum = -1;
                int cname = -1;
                int ename = -1;
                int etime = -1;
                int sdepartment = -1;
                int preapplied = -1;
                int auto = -1;
                int manual = -1;
                string str = null;
                int col = 1;
                do
                {
                    str = (string)(worksheet.Cells[1, col] as Range).Value;
                    if (null == str)
                        break;
                    else
                    {
                        switch (str)
                        {
                            case "工号":
                                jobnum = col;
                                break;
                            case "中文名":
                                cname = col;
                                break;
                            case "英文名":
                                ename = col;
                                break;
                            case "入职日期":
                                etime = col;
                                break;
                            case "小部门":
                                sdepartment = col;
                                break;
                            case "去年已休":
                                preapplied = col;
                                break;
                            case "计算方式":
                                auto = col;
                                break;
                            case "固定年假":
                                manual = col;
                                break;
                        }
                    }
                    ++col;
                } while (true);
                if (!OperationData.EmpolyeeData.ContainsKey(worksheet.Name))
                {
                    OperationData.EmpolyeeData.Add(worksheet.Name, new AVMSDT.DepartmentOperationData
                    {
                        FileID = Guid.NewGuid().ToString(),
                        SubDepartment = -1 != sdepartment,
                        IsOpen = true,
                        Empolyees = new Dictionary<string, AVMSDT.EmployeePersonalInformation>()
                    });
                }
                if (-1 != jobnum && -1 != cname && -1 != etime)
                    ImportSheet(worksheet, OperationData.EmpolyeeData[worksheet.Name].Empolyees, jobnum, cname, ename, etime, preapplied, sdepartment, auto, manual);
                else
                    result = false;
            }
            return result;
        }
        private void ImportSheet(Worksheet worksheet, Dictionary<string, AVMSDT.EmployeePersonalInformation> employee, params int[] param)
        {
            int jobnum = param[0], cname = param[1], ename = param[2], etime = param[3], sdepartment = param[5], preapplied = param[4];
            int auto = param[6], manual = param[7];

            for (int row = 2; ; ++row) 
            {
                string jn = (string)(worksheet.Cells[row, jobnum] as Range).Value;
                if (null != jn)
                {
                    if (!employee.ContainsKey(jn))
                    {
                        int papplied = 0;
                        if (-1 != preapplied)
                            int.TryParse((string)(worksheet.Cells[row, preapplied] as Range).Value, out papplied);
                        bool autocalculate = true;
                        int manualtime = 0;
                        if (-1 != auto)
                        {
                            autocalculate = "手动" != (string)(worksheet.Cells[row, auto] as Range).Value;
                            if (!autocalculate && -1 != manual)
                                int.TryParse((string)(worksheet.Cells[row, manual] as Range).Value, out manualtime);
                        }
                        employee.Add(jn, new AVMSDT.EmployeePersonalInformation
                        {
                            Name = (string)(worksheet.Cells[row, cname] as Range).Value,
                            EntryTime = DateTime.Parse((worksheet.Cells[row, etime] as Range).Value.ToString()),
                            EnglishName = -1 != ename ? (string)(worksheet.Cells[row, ename] as Range).Value : "",
                            SubDepartment = -1 != sdepartment ? (string)(worksheet.Cells[row, sdepartment] as Range).Value : "",
                            LastApplied = papplied,
                            AutoCalculate = autocalculate,
                            ManualTime = manualtime
                        });
                    }
                }
                else
                    break;
            }
        }

        public void Close()
        {
            Workbook.Close();
            ApplicationClass.Quit();
        }
    }
}
