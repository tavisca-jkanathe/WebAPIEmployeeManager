using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIExample.Models;

namespace WebAPIExample.Controllers
{
    public class EmployeeController : ApiController
    {


        IList<Employee> employees = new List<Employee>()
        {
            new Employee()
                {
                    EmployeeId = 1, EmployeeName = "A", Salary ="30000", Age ="23", Address = "N", Department = "I", Mid =1
                },
                new Employee()
                {
                    EmployeeId = 2, EmployeeName = "B", Salary ="30000", Age ="23", Address = "L", Department = "F", Mid =1
                },
                new Employee()
                {
                    EmployeeId = 3, EmployeeName = "C",Salary ="30000", Age ="23", Address = "H", Department = "I", Mid =2
                },
                new Employee()
                {
                    EmployeeId = 4, EmployeeName = "D",Salary ="30000", Age ="23", Address = "G", Department = "S", Mid =3
                },
                new Employee()
                {
                    EmployeeId = 5, EmployeeName = "M",Salary ="30000", Age ="23", Address = "N", Department = "S", Mid =3
                },
        };
        
        public IList<Employee> GetAllEmployees()
        {
            //Return list of all employees  
            return employees;
        }
        public IList<Employee> GetEmployeeDetails(int id)
        {
            IList<Employee> employeesupdated = new List<Employee>();
          //  employeesupdated.
            //Return a single employee detail  
            //var  employee = employees.FirstOrDefault(e => e.Mid == id);
            foreach(Employee e in employees)
            {
                if(e.Mid == id)
                {
                    employeesupdated.Add(e);
                }
            }
          // var  employee = employees.
            if (employeesupdated == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }
            return employeesupdated;
        }


        // POST api/values
        public void Post([FromBody]int empid,
            string empname,
            string empsal,
            string empage,
            string empadd,
            string empdept,
            int empmid )
        {
            employees.Add(new Employee()
            {
                EmployeeId = empid,
                EmployeeName = empname,
                Salary = empsal,
                Age = empage,
                Address = empadd,
                Department = empdept,
                Mid = empmid  
            });
        }


    }
}
