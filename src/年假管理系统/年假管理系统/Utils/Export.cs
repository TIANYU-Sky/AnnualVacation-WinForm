using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AVMSDT;
using Microsoft.Office.Interop.Excel;

namespace 年假管理系统.Utils
{
    internal class Export
    {
        private ApplicationClass ApplicationClass;
        private Workbook Workbook;

        public Export()
        {
            ApplicationClass = new ApplicationClass();
            Workbook = ApplicationClass.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
        }

        public bool ExportData()
        {
            Dictionary<string, DepartmentOperationData> data = OperationData.EmpolyeeData;
            // 遍历数据结构 写入文档
            bool first = true;
            foreach (KeyValuePair<string, DepartmentOperationData> i in data)
            {
                Worksheet worksheet = null;
                if (first)
                {
                    worksheet = (Worksheet)Workbook.Sheets[1];
                    first = false;
                }
                else
                    worksheet = (Worksheet)Workbook.Worksheets.Add();
                worksheet.Name = "" == i.Key ? "未分配部门" : i.Key;
                if (i.Value.SubDepartment)
                    ExportWithSubDepartment(worksheet, i.Value.Empolyees);
                else
                    ExportWithNoSubDepartment(worksheet, i.Value.Empolyees);
            }
            return true;
        }
        private void ExportWithSubDepartment(Worksheet worksheet, Dictionary<string, EmployeePersonalInformation> employees)
        {
            worksheet.Cells[1, 1] = "工号";
            worksheet.Cells[1, 2] = "中文名";
            worksheet.Cells[1, 3] = "英文名";
            worksheet.Cells[1, 4] = "入职时间";
            worksheet.Cells[1, 5] = "小部门";
            worksheet.Cells[1, 6] = "去年年假新增";
            worksheet.Cells[1, 7] = "去年年假已休";
            worksheet.Cells[1, 8] = "年假延期";
            worksheet.Cells[1, 9] = "今年年假新增";
            for (int i = 0; i < 12; ++i)
                worksheet.Cells[1, 10 + i] = (i + 1) + "月";
            worksheet.Cells[1, 22] = "今年年假总数";
            worksheet.Cells[1, 23] = "本月可休年假";
            worksheet.Cells[1, 24] = "今年已休年假";
            int row = 2;
            foreach (KeyValuePair<string, EmployeePersonalInformation> i in employees)
            {
                worksheet.Cells[row, 1] = i.Key;
                worksheet.Cells[row, 2] = i.Value.Name;
                worksheet.Cells[row, 3] = i.Value.EnglishName;
                worksheet.Cells[row, 4] = AVMSBT.Method.GeneralMethods.StructuredToString(i.Value.EntryTime);
                worksheet.Cells[row, 5] = i.Value.SubDepartment;

                double prevac = 0.0, currvac = 0.0;
                double[] month = new double[12];
                if (i.Value.AutoCalculate)
                {
                    prevac = AVMSBT.Method.AnnualVacation.AutoCalculatePassed(i.Value.EntryTime);
                    currvac = AVMSBT.Method.AnnualVacation.AutoCalculateCurrent(i.Value.EntryTime, month);
                }
                else
                {
                    prevac = AVMSBT.Method.AnnualVacation.StaticCalculatePassed(i.Value.EntryTime, i.Value.ManualTime);
                    prevac = AVMSBT.Method.AnnualVacation.StaticCalculateCurrent(i.Value.EntryTime, i.Value.ManualTime, month);
                }

                worksheet.Cells[row, 6] = AVMSBT.Method.GeneralMethods.StructuredToString(prevac);
                worksheet.Cells[row, 7] = i.Value.LastApplied.ToString();
                double delay = prevac - i.Value.LastApplied;
                worksheet.Cells[row, 8] = AVMSBT.Method.GeneralMethods.StructuredToString(delay);
                worksheet.Cells[row, 9] = AVMSBT.Method.GeneralMethods.StructuredToString(currvac);
                for (int j = 0; j < 12; ++j)
                    worksheet.Cells[row, 10 + j] = AVMSBT.Method.GeneralMethods.StructuredToString(month[j]);
                worksheet.Cells[row, 22] = AVMSBT.Method.GeneralMethods.StructuredToString(delay + currvac);
                double vaild = 0.0;
                for (int j = 0; j < DateTime.Today.Month; ++j)
                    vaild += month[j];
                worksheet.Cells[row, 23] = AVMSBT.Method.GeneralMethods.StructuredToString(vaild + delay - i.Value.Applied);
                worksheet.Cells[row, 24] = i.Value.Applied.ToString();
                ++row;
            }
        }
        private void ExportWithNoSubDepartment(Worksheet worksheet, Dictionary<string, EmployeePersonalInformation> employees)
        {
            worksheet.Cells[1, 1] = "工号";
            worksheet.Cells[1, 2] = "中文名";
            worksheet.Cells[1, 3] = "英文名";
            worksheet.Cells[1, 4] = "入职时间";
            worksheet.Cells[1, 5] = "去年年假新增";
            worksheet.Cells[1, 6] = "去年年假已休";
            worksheet.Cells[1, 7] = "年假延期";
            worksheet.Cells[1, 8] = "今年年假新增";
            for (int i = 0; i < 12; ++i)
                worksheet.Cells[1, 9 + i] = (i + 1) + "月";
            worksheet.Cells[1, 21] = "今年年假总数";
            worksheet.Cells[1, 22] = "本月可休年假";
            worksheet.Cells[1, 23] = "今年已休年假";
            int row = 2;
            foreach (KeyValuePair<string, EmployeePersonalInformation> i in employees)
            {
                worksheet.Cells[row, 1] = i.Key;
                worksheet.Cells[row, 2] = i.Value.Name;
                worksheet.Cells[row, 3] = i.Value.EnglishName;
                worksheet.Cells[row, 4] = AVMSBT.Method.GeneralMethods.StructuredToString(i.Value.EntryTime);

                double prevac = 0.0, currvac = 0.0;
                double[] month = new double[12];
                if (i.Value.AutoCalculate)
                {
                    prevac = AVMSBT.Method.AnnualVacation.AutoCalculatePassed(i.Value.EntryTime);
                    currvac = AVMSBT.Method.AnnualVacation.AutoCalculateCurrent(i.Value.EntryTime, month);
                }
                else
                {
                    prevac = AVMSBT.Method.AnnualVacation.StaticCalculatePassed(i.Value.EntryTime, i.Value.ManualTime);
                    prevac = AVMSBT.Method.AnnualVacation.StaticCalculateCurrent(i.Value.EntryTime, i.Value.ManualTime, month);
                }

                worksheet.Cells[row, 5] = AVMSBT.Method.GeneralMethods.StructuredToString(prevac);
                worksheet.Cells[row, 6] = i.Value.LastApplied.ToString();
                double delay = prevac - i.Value.LastApplied;
                worksheet.Cells[row, 7] = AVMSBT.Method.GeneralMethods.StructuredToString(delay);
                worksheet.Cells[row, 8] = AVMSBT.Method.GeneralMethods.StructuredToString(currvac);
                for (int j = 0; j < 12; ++j)
                    worksheet.Cells[row, 9 + j] = AVMSBT.Method.GeneralMethods.StructuredToString(month[j]);
                worksheet.Cells[row, 21] = AVMSBT.Method.GeneralMethods.StructuredToString(delay + currvac);
                double vaild = 0.0;
                for (int j = 0; j < DateTime.Today.Month; ++j)
                    vaild += month[j];
                worksheet.Cells[row, 22] = AVMSBT.Method.GeneralMethods.StructuredToString(vaild + delay - i.Value.Applied);
                worksheet.Cells[row, 23] = i.Value.Applied.ToString();
                ++row;
            }
        }

        public void Save(string path)
        {
            Workbook.SaveAs(path);
        }
        public void Close()
        {
            Workbook.Close();
            ApplicationClass.Quit();
        }
    }
}
