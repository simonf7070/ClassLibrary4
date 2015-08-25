using System;
using Moq;
using NUnit.Framework;

namespace ClassLibrary4
{
    public class EmployeeDal : IDisposable
    {
        public virtual void Dispose()
        {
            // dispose
        }
    }

    public class EmployeeService
    {
        public EmployeeService(EmployeeDal employeeDal)
        {
            using (employeeDal)
            {
                // do something
            }
        }
    }

    [TestFixture]
    public class Tests
    {
        [Test]
        public void ObjectDisposesCorrectly()
        {
            var employeeDal = new Mock<EmployeeDal>();      

            var employeeService = new EmployeeService(employeeDal.Object);
            
            employeeDal.Verify(x => x.Dispose(), Times.Once);
        }
    }
}
