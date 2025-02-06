using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Company 
{
    public enum ensecuritylevel 
    {
        guest, Developer, secretary, DBA
    }
    public class Employee : HiringDate
    {
        #region Attributes
        private int id;
        private string name;
        private ensecuritylevel securitylevel;
        private double salary;
        private char gender;

        #endregion

        #region Constructor
        public Employee(int id, string name, ensecuritylevel securitylevel, double salary, int Day, int Month, int Year, char gender) : base (Year, Month, Day)
        {
            this.id = id;
            this.name = name;
            this.securitylevel = securitylevel;
            this.salary = salary;
            Gender = gender;
        }
        #endregion

        #region Properties
        public int ID
        { get { return id; } }
        public string Name
        { 
          get { return name; }
          set 
          { 
             if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Error Name can't be null");
             else
                name = value;
           }
        }
        public ensecuritylevel SecurityLevel  
        { 
            get { return securitylevel; } 
            set { securitylevel = value; }
        }
        public double Salary
        {   
            get { return salary; } 
            set { salary = value; } 
        }
        public char Gender
        {
            get { return gender; }
            set
            {
                if (char.ToUpper(value) == 'F' || char.ToUpper(value) == 'M')
                { gender = value; }
                else { gender = 'M'; }
            }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"ID: {id}\nName: {name}\nsecurity level: {securitylevel}\nSalary: {string.Format("{0:C}", salary)}\nHire Date: {Day}/{Month}/{Year}\nGender {gender}";
        }
        #endregion

    }
}
