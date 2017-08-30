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
    public class MCTests
    {
        [TestMethod()]
        public void PrisTest()
        {
            //Arrange
            var mc = new MC();

            //Act
            int Pris = mc.Pris();

            ////Assert
            Assert.AreEqual(125, Pris);
        }

        [TestMethod()]
        public void KøretøjTest()
        {
            //Arrange
            var mc = new MC();

            //Act
            string Køretøj = mc.Køretøj();

            ////Assert
            Assert.AreEqual("MC", Køretøj);
        }
    }
}