using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ZeniExample.Base.Repository;
using ZeniExample.Core.Models.HumanResources;

namespace ZeniExample.API.Controllers
{
    [Route("api/GetDepartments")]    
    public class DepartmentsController : ApiController
    {
        public IEnumerable<Department> Get()
        {
            using (var repo = new DepartmentRepository())
            {
                return repo.GetDepartments().ToList();
            }
        }
    }
}
