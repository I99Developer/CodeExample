using System;
using System.Collections;
using System.Collections.Generic;
using ZeniExample.Base.Context;
using ZeniExample.Core.Models;
using ZeniExample.Core.Models.HumanResources;
using ZeniExample.Core.RepositoryInterfaces;

namespace ZeniExample.Base.Repository
{
    public class DepartmentRepository : IDepartmentRepository, IDisposable
    {
        DepartmentContext m_Context;
        public void Dispose()
        {
            m_Context.Dispose();
        }

        public IEnumerable<Department> GetDepartments()
        {
            m_Context = new DepartmentContext();

            return m_Context.Departments;
        }
    }
}
