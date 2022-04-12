using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Programmeerpuzzels.tests
{
    [TestClass]
    public class WetenschappersTest
    {
        public void Generate(BestTimeForWettenschappers bestTime)
        {
            bestTime.wetenschappers.Add(new Wetenschapper("Carl Sagan", 1934, 1996));
            bestTime.wetenschappers.Add(new Wetenschapper("Charles Darwin", 1809, 1882));
            bestTime.wetenschappers.Add(new Wetenschapper("Charles - Augustin de Coulomb", 1736, 1806));
            bestTime.wetenschappers.Add(new Wetenschapper("Edwin Hubble", 1889, 1953));
            bestTime.wetenschappers.Add(new Wetenschapper("Enrico Fermi", 1901, 1954));
            bestTime.wetenschappers.Add(new Wetenschapper("Gottfried Wilhelm Leibniz", 1646, 1716));
            bestTime.wetenschappers.Add(new Wetenschapper("Gregor Mendel", 1822, 1884));
            bestTime.wetenschappers.Add(new Wetenschapper("Guglielmo Marconi", 1874, 1937));
            bestTime.wetenschappers.Add(new Wetenschapper("Heinrich Hertz", 1857, 1894));
            bestTime.wetenschappers.Add(new Wetenschapper("Isaac Newton", 1642, 1727));
            bestTime.wetenschappers.Add(new Wetenschapper("James Clerk Maxwell", 1831, 1879));
            bestTime.wetenschappers.Add(new Wetenschapper("James Prescott Joule", 1818, 1889));
        }

        [TestMethod]
        public void GenerateWetenschappersTest()
        {
            //Arrange
            BestTimeForWettenschappers bestTime = new BestTimeForWettenschappers();

            //Act
            bestTime.Generate();

            //Assert
            Assert.IsNotNull(bestTime.wetenschappers);
        }

        [TestMethod]
        public void MostAliveTest()
        {
            //Arrange
            int expected = 1874;

            BestTimeForWettenschappers bestTime = new BestTimeForWettenschappers();
            Generate(bestTime);

            //Act
            int actual = bestTime.MostAlive();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
