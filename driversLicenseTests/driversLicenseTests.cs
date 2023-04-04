using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assessment2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace License.Tests
{
    [TestClass()]
    public class LicenseTests
    {
        
        [TestMethod()]
        public void licensePlateTests()
        {
            LicensePlateClass l = new();
            string result = l.LicensePlate("5F3Z-2e-9-w", 4);
            if(result.Equals("5F3Z-2E9W"))
            {
                Assert.IsTrue(true);
            }
            else { Assert.Fail(); }
        }
    }
}