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
        public void driversLicenseTest()
        {
            driversLicenseClass p = new();
            int time = p.driversLicense("Eric", 2, "Adam Caroline Rebecca Frank");
            if (time == 40)
            {
                Assert.IsTrue(true);
            }
            else { Assert.Fail(); }
        }
    }
}