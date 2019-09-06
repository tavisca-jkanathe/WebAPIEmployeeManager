using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIExample.Models;

namespace WebAPIExample.Controllers
{
    public class ManagerController : ApiController
    {


        IList<Manager> managers = new List<Manager>()
        {
            new Manager()
                {
                    ManagerId = 1, ManagerName = "man1",  },
            new Manager()
                {
                    ManagerId = 2, ManagerName = "man2",  },
            new Manager()
                {
                    ManagerId = 3, ManagerName = "man3",  },

        };

        public IList<Manager> GetAllEmployees()
        {
            //Return list of all employees  
            return managers;
        }
        public Manager GetEmployeeDetails(int id)
        {
            //Return a single employee detail  
            var manager = managers.FirstOrDefault(e => e.ManagerId == id);
            if (manager == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }
            return manager;
        }

       


    }
}
