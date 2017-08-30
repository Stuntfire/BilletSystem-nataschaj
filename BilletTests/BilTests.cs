using Microsoft.VisualStudio.TestTools.UnitTesting;
using Billet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billet.Tests
{
    [TestClass()]
    public class BilTests
    {
        [TestMethod()]
        public void PrisTestBil()
        {
            //Arrange
            var bil = new Bil();

            //Act
            int Pris = bil.Pris();

            ////Assert
            Assert.AreEqual(240, Pris);
        }

        [TestMethod()]
        public void KøretøjTestBil()
        {
            //Arrange
            var bil = new Bil();

            //Act
            string Køretøj = bil.Køretøj();

            ////Assert
            Assert.AreEqual("Bil", Køretøj);
        }
    }
}