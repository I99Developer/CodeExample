using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeniExample.Core.Models.HumanResources;

namespace ZeniExample.Base.Context
{
    public class DepartmentContext : DbContext
    {
        public DepartmentContext () : base("name=AdvWrks2017")
        { }

        public DbSet<Department> Departments { get; set; }
    }
}
