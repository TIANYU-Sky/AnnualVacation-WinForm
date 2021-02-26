using System;
using System.Collections.Generic;
using System.Text;

namespace AVMSBT.Method
{
    public class AnnualVacation
    {
        public static void Calculate(AVMSDT.EmployeePersonalInformation information)
        {

        }
        public static double StaticCalculateCurrent(DateTime date, int manual, double[] month)
        {
            double sum_vacation = 0.0;
            if (DateTime.Today.Year > date.Year)
            {
                if (1 == DateTime.Today.Year - date.Year)
                {
                    for (int i = 0; i < date.Month - 1; ++i)
                        month[i] = 0;
                    month[date.Month - 1] = manual + (double)manual / AVMSDT.StaticData.AnnualVacationData.MonthPreYear;
                    sum_vacation = month[date.Month - 1];
                    for (int i = date.Month; i < AVMSDT.StaticData.AnnualVacationData.MonthPreYear; ++i) 
                    {
                        month[i] = (double)manual / AVMSDT.StaticData.AnnualVacationData.MonthPreYear;
                        sum_vacation += month[i];
                    }
                }
                else
                {
                    for (int i = 0; i < AVMSDT.StaticData.AnnualVacationData.MonthPreYear; ++i)
                        month[i] = (double)manual / AVMSDT.StaticData.AnnualVacationData.MonthPreYear;
                    sum_vacation = manual;
                }
            }
            return sum_vacation;
        }
        public static double StaticCalculatePassed(DateTime date, int manual)
        {
            if (DateTime.Today.Year > date.Year)
            {
                if (1 == DateTime.Today.Year - date.Year)
                    return 0;
                if (2 == DateTime.Today.Year - date.Year)
                {
                    int days = (int)(new DateTime(DateTime.Today.Year, 12, 31) - new DateTime(DateTime.Today.Year, date.Month, date.Day)).TotalDays;
                    return manual + manual * ((double)days / AVMSDT.StaticData.AnnualVacationData.DaysPreYear);
                }
                else
                    return manual;
            }
            return 0.0;
        }
        public static double AutoCalculateCurrent(DateTime date, double[] month)
        {
            double sum_vacation = 0.0;

            if (DateTime.Today.Year > date.Year)
            {
                DateTime now = DateTime.Today;
                int year_differ = now.Year - date.Year;
                if (8 <= year_differ) 
                {
                    for (int i = 0; i < month.Length; ++i)
                        month[i] = (double)15/AVMSDT.StaticData.AnnualVacationData.MonthPreYear;
                    return 15;
                }
                double vpreday = 0.0, vpassday = 0.0;
                // 年假每天的时间计算
                {
                    int vlevelpre = 0, vlevelpass = 0;
                    switch (year_differ)
                    {
                        case 1:
                            vlevelpre = 0;
                            vlevelpass = 8;
                            break;
                        case 2:
                            vlevelpre = 8;
                            vlevelpass = 10;
                            break;
                        case 3:
                            vlevelpre = 10;
                            vlevelpass = 11;
                            break;
                        case 4:
                            vlevelpre = 11;
                            vlevelpass = 12;
                            break;
                        case 5:
                            vlevelpre = 12;
                            vlevelpass = 13;
                            break;
                        case 6:
                            vlevelpre = 13;
                            vlevelpass = 14;
                            break;
                        case 7:
                            vlevelpre = 14;
                            vlevelpass = 15;
                            break;
                        default:
                            vlevelpre = 15;
                            vlevelpass = 15;
                            break;

                    }
                    vpreday = (double)vlevelpre / AVMSDT.StaticData.AnnualVacationData.DaysPreYear;
                    vpassday = (double)vlevelpass / AVMSDT.StaticData.AnnualVacationData.DaysPreYear;
                }
                int monthindex = 0;
                // 前半年每月年假计算
                for (; monthindex < date.Month - 1; ++monthindex)
                {
                    month[monthindex] = vpreday * AVMSDT.StaticData.AnnualVacationData.DaysPreMonth[monthindex];
                    sum_vacation += month[monthindex];
                }
                // 入职当月年假计算
                {
                    // 计算入职日期距离当月1号的时间
                    int dayspre = (int)(new DateTime(DateTime.Today.Year, date.Month, date.Day) - new DateTime(DateTime.Today.Year, date.Month, 1)).TotalDays;
                    month[monthindex] = dayspre * vpreday + (AVMSDT.StaticData.AnnualVacationData.DaysPreMonth[monthindex] - dayspre) * vpassday + (1 == year_differ ? 8 : 0);
                    sum_vacation += month[monthindex];
                    ++monthindex;
                }
                // 后半年每月年假计算
                for (; monthindex < AVMSDT.StaticData.AnnualVacationData.MonthPreYear; ++monthindex)
                {
                    month[monthindex] = vpassday * AVMSDT.StaticData.AnnualVacationData.DaysPreMonth[monthindex];
                    sum_vacation += month[monthindex];
                }
            }
            else
                for (int i = 0; i < month.Length; ++i)
                    month[i] = 0.0;

            //return GeneralMethods.MathDoubleToInt(sum_vacation);
            return sum_vacation;
        }
        public static double AutoCalculatePassed(DateTime date)
        {
            double sum_vacation = 0.0;

            if (DateTime.Today.Year > date.Year)
            {
                DateTime now = DateTime.Today;
                int year_differ = now.Year - date.Year;
                if (1 == year_differ)
                    return 0;
                if (9 <= year_differ)
                    return 15;
                int vlevelpre = 0, vlevelpass = 0;
                // 年假每天的时间计算
                {
                    switch (year_differ)
                    {
                        case 2:
                            vlevelpre = 0;
                            vlevelpass = 8;
                            break;
                        case 3:
                            vlevelpre = 8;
                            vlevelpass = 10;
                            break;
                        case 4:
                            vlevelpre = 10;
                            vlevelpass = 11;
                            break;
                        case 5:
                            vlevelpre = 11;
                            vlevelpass = 12;
                            break;
                        case 6:
                            vlevelpre = 12;
                            vlevelpass = 13;
                            break;
                        case 7:
                            vlevelpre = 13;
                            vlevelpass = 14;
                            break;
                        default:
                            vlevelpre = 14;
                            vlevelpass = 15;
                            break;

                    }
                }
                int predays = (int)(new DateTime(DateTime.Today.Year, date.Month, date.Day) - new DateTime(DateTime.Today.Year, 1, 1)).TotalDays;
                sum_vacation = ((double)((vlevelpre - vlevelpass) * predays)) / AVMSDT.StaticData.AnnualVacationData.DaysPreYear + vlevelpass + (2 == year_differ ? 8 : 0);
            }

            //return GeneralMethods.MathDoubleToInt(sum_vacation);
            return sum_vacation;
        }
    }
}
