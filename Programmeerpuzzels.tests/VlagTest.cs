using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Programmeerpuzzels.tests
{
    [TestClass]
    public class VlagTest
    {
        [TestMethod]
        public void VlagGenerateTest()
        {
            //Arrange
            Vlag vlag = new Vlag();

            //Act
            vlag.Generate();

            //Assert
            Assert.IsNotNull(vlag.Colors);
        }

        [TestMethod]
        public void VlagSortTest()
        {
            //Arrange
            List<string> colors = new List<string>() { "Rood", "Wit", "Rood", "Wit", "Wit", "Rood" };
            List<string> expected = new List<string>() { "Rood", "Rood", "Rood", "Wit", "Wit", "Wit" };
            Vlag vlag = new Vlag();

            //Act
            vlag.Colors = colors;
            vlag.SortVlag();

            //Assert
            for (int i = 0; i < vlag.Colors.Count; i++)
            {
                Assert.AreEqual(expected[i], vlag.Colors[i]);
            }
        }
    }
}
