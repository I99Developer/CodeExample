using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeniExample.Base.Repository;
using ZeniExample.Core.Models.HumanResources;

namespace ZeniExample.Tests
{
    [TestClass]
    public class DepartmentTest
    {
        [TestMethod]
        public void TestGetProducts()
        {
            using (var repo = new DepartmentRepository())
            {
                var departments = repo.GetDepartments();
                Assert.IsNotNull(departments);
                var departmentCount = departments.ToList();
                Assert.AreNotEqual(0, departmentCount);
            }
        }
    }
}
