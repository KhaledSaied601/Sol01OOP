using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Ass01OOP
{
    /// <summary>
    /// 
    /// //////////////// Part 02 :Encapsulation
    /// 
    /// </summary>
    /// 

    #region 2- Develop a Class to represent the Hiring Date Data: consisting of fields to hold the day, month and Years.


    class HiringDate()
    {

        public int HiringDay;

        public int HiringMonth;

        public int HiringYear;

        public HiringDate(int _hiringDay,int _hiringMonth,int _hiringYear):this() 
        {
            HiringDay= _hiringDay;
            HiringMonth= _hiringMonth;
            HiringYear= _hiringYear;
        }

        public override string ToString()
        {
            return $"{HiringDay}/{HiringMonth}/{HiringYear}";
        }


    }

    #endregion


    #region 3- We need to restrict the Gender field to be only M or F [Male or Female] 

    enum Gender
    {
        Male = 0,
        Female = 1,
        M = 0,
        F= 1
    }


    #endregion


    #region 4-  Assign the following security privileges to the employee (guest, Developer, secretary and DBA) in a form of Enum

    [Flags]
    enum SecurityLevel:byte
    {
        Guest=1,
        Developer=2, 
        Secretary=4 , 
        DBA=8
    }

    #endregion


    #region 1- Design and implement a Class for the employees in a company:

    internal class Employees
    {
        public int ID { get; set; }
        public string Name { get; set; }


        public SecurityLevel SecurityLevel { get; set; }

        public double Salary { get; set; }

        public HiringDate HiringDate { get; set; }

        public Gender Gender { get; set; }

        public Employees( )
        {
            
        }

        public override string ToString()
        {
            return String.Format("{0} LE", Salary);
        }




    }

    #endregion
}
