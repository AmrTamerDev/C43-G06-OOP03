using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class HiringDate
    {
        #region Attribues
        int day;
        int month;
        int year;
       
        #endregion

        #region Properties
        public int Day
        {
            get
            {
                return day;
            }
            set
            {
                bool CheckYear = IsLeapYear(year);
                int Month = month;
                if (Month == 1 || Month == 3 || Month == 5 || Month == 7 || Month == 8 || Month == 10 || Month == 12)
                {    if (value >= 1 && value <= 31)
                        { day = value; }
                    else
                        throw new ArgumentOutOfRangeException("Error Day must be between 1 and 31");
                }
                else if (Month == 4 || Month == 6 || Month == 9 || Month == 11)
                {    if (value >= 1 && value <= 30)
                         { day = value; }
                    else
                        throw new ArgumentOutOfRangeException("Error Day must be between 1 and 30");
                }
                else
                {
                    if (CheckYear)
                        if (value >= 1 && value <= 29)
                            { day = value; }
                        else
                            throw new ArgumentOutOfRangeException("Error Day must be between 1 and 29");
                    else
                        if (value >= 1 && value <= 28)
                            { day = value; }
                    else
                        throw new ArgumentOutOfRangeException("Error Day must be between 1 and 28");
                }
            }
        }
        public int Month
        {
            get { return month; }
            set 
            {
                if (value >= 1 && value <= 12)
                    month = value;
                else
                    throw new ArgumentOutOfRangeException("Error Day must be between 1 and 12");
            }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        #endregion

        #region Constructor
        public HiringDate(int year, int month, int day)
        {
            this.year = year;
            Month = month;
            Day = day;
        }

        #endregion

        #region Methods
        static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        public override string ToString()
        {
            return $"Day = {day}\nMonth = {month}\nYear = {year}";
        }
        #endregion
    }
}
