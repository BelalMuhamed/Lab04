using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Part01
{
    internal static class Helper
    {
        #region Swap
        public static void Swap(ref Employee E01,ref Employee E02)
        {
            Employee Temp = new Employee();
            Temp = E01;
            E01 = E02;
            E02 = Temp;
        }
        #endregion

        #region SortBasedOnHiringDate
        public static void SortBasedOnHiringDate(this Employee[] Employees)
        {
            for (int i = 0; i < Employees.Length; i++) 
            {
                for (int j = i+1; j < Employees.Length; j++) 
                {
                    if (Employees[i].HiringDate.Year>Employees[j].HiringDate.Year)
                    {
                        Swap(ref Employees[i], ref Employees[j]);
                    }
                    else if(Employees[i].HiringDate.Year == Employees[j].HiringDate.Year)
                    {
                        if (Employees[i].HiringDate.Month > Employees[j].HiringDate.Month)
                        {
                            Swap(ref Employees[i], ref Employees[j]);
                        }
                        else if (Employees[i].HiringDate.Year == Employees[j].HiringDate.Year)
                        {
                            if (Employees[i].HiringDate.Day > Employees[j].HiringDate.Day)
                            {
                                Swap(ref Employees[i], ref Employees[j]);
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
    #endregion
    }
}
