using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIExample.Models
{
   
        public class Employee
        {
        public Employee()
        {

        }
        public Employee (int employeeId,
            string employeeName,
            string address,
            string dept,
            int mid,
            string salary,
            string age)
        {
            this.EmployeeId = employeeId;
            this.EmployeeName = employeeName;
            this.Address = address;
            this.Department = dept;
            this.Mid = mid;
            this.Salary = salary;
            this.Age = age;
        }
            public int EmployeeId
            {
                get;
                set;
            }
            public string EmployeeName
            {
                get;
                set;
            }
            public string Address
            {
                get;
                set;
            }
            public string Department
            {
                get;
                set;
            }
            public int Mid
            {
                get;
                set;
            }
            public string Salary
            {
               get;
               set;
            }
            public string Age
            {
                get;
                set;
            }
    }
    
}