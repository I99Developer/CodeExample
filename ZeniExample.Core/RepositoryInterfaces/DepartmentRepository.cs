using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeniExample.Core.Models;
using ZeniExample.Core.Models.HumanResources;

namespace ZeniExample.Core.RepositoryInterfaces
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetDepartments();
    }
}
