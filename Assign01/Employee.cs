using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign01
{
	enum Gender
    {
        Male,
        Female

    }

    public enum SecurityPrivilege
    {
        Guest,
        Developer,
        Secretary,
        DBA
    }
    public class HiringDate
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }


        public HiringDate(int day, int month, int year)
        {
            if (day < 1 || day > 31)
                throw new ArgumentOutOfRangeException(nameof(day), "Day must be between 1 and 31");
            if (month < 1 || month > 12)
                throw new ArgumentOutOfRangeException(nameof(month), "Month must be between 1 and 12");
            if (year < 1900 || year > DateTime.Now.Year)
                throw new ArgumentOutOfRangeException(nameof(year), "Year must be between 1900 and the current year");
            Day = day;
            Month = month;
            Year = year;
        }
        public override string ToString()
        {
            return $"{Day:D2}/{Month:D2}/{Year}";
        }
    }
        internal class Employee
    {
   
		 private int id;
		 private string name;
		 private SecurityPrivilege securityLevel;
		 private double salary;
		 private DateTime hireDate;
		 private Gender gender;
         
         
   //      public int Day { get; set; }
		 //public int Month { get; set; }
		 //public int Year { get; set; }
         
		 //public void 
         public Gender Gender
         {
		 	get { return gender; }
		 	set { gender = value; }
		 }
         
		 public HiringDate HireDate
		 {
            get;
            set;
		 }
         
		 public double Salary
		 {
		 	get { return salary; }
		 	set { salary = value; }
		 }
         
         
		 public SecurityPrivilege SecurityLevel
         {
		 	get { return securityLevel; }
		 	set { securityLevel = value; }
		 }
         
         
		 public string Name
		 {
		 	get { return name; }
		 	set { name = value; }
		 }
         
		 public int  Id
		 {
		 	get { return id; }
		 	set { id = value; }
		 }
         
         public Employee(int id, string name, Gender gender, double salary, HiringDate hireDate, SecurityPrivilege securityLevel)
         {
             Id = id;
             Name = name;
             Gender = gender;
             Salary = salary;
             HireDate = hireDate;
             SecurityLevel = securityLevel;
         }
         public override string ToString()
		 {
		 	return string.Format(
		 		"ID: {0}, Name: {1}, Gender: {2}, Salary: {3}, Hire Date: {4}, Security Level: {5}",
		 		Id,
		 		Name,
                 Gender.ToString(),
                 string.Format("{0:C}", Salary),
                 HireDate.ToString(),
                 SecurityLevel.ToString()
             );
		 }
        }    
}
