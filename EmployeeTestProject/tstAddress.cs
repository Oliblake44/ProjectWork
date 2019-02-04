using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectClassLibrary;

namespace EmployeeTestProject
{
    [TestClass]
    public class tstAddress
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsAddress Anaddress = new clsAddress();
            Assert.IsNotNull(Anaddress);
        }
    }
}
