using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIExample.Controllers
{
    public class Employees
    {
        public Employees(int empid, string name, string email, string salary, string age, string managerid)
        {
            this.Empid = empid;
            this.Name = name;
            this.Email = email;
            this.Salary = salary;
            this.Age = age;
            this.Managerid = managerid;
        }
        public int Empid { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Salary { get; set; }
        public string Age { get; set; }
        public string Managerid { get; set; }

        void initializeemployee()
        {
           
             List<Employees> employees = new List<Employees>();
            Employees data = new Employees(1, "emp1", "emp1@a.b", "30000", "23", "1");
            employees.Add(data);
             data = new Employees(2, "emp2", "emp2@a.b", "30000", "23", "2");
            employees.Add(data);
            data = new Employees(3, "emp3", "emp3@a.b", "30000", "23", "3");
            employees.Add(data);
            data = new Employees(4, "emp4", "emp4@a.b", "30000", "23", "3");
            employees.Add(data);
            data = new Employees(5, "emp5", "emp5@a.b", "30000", "23", "2");
            employees.Add(data);
        }
       
    }
    public class ValuesController : ApiController
    {
        
       
        
        
        
        
       
        
        

        List<string> managers = new List<string>()
    {
        "man1", "man2", "man3"
    };

        // GET api/values
        public IEnumerable<string> Get()
        {
            //return new string[] { "value1", "value2" };
            return managers;
        }
     

        // GET api/values/5
        public string Get(int id)
        {
            if (id <= (managers.Count) && id > 0)
                return managers[id - 1];
            else if (id > (managers.Count))
                return "Manager not found";
            else
                return "Invalid manager ID";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            managers.Add(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
