using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmeerpuzzels
{
    public class BestTimeForWettenschappers
    {
        public List<Wetenschapper> wetenschappers = new List<Wetenschapper>();
        public void Generate()
        {
            wetenschappers.Add(new Wetenschapper("Albert Einstein", 1879, 1955));
            wetenschappers.Add(new Wetenschapper("Alessandro Volta", 1745, 1827));
            wetenschappers.Add(new Wetenschapper("Alexander Fleming", 1881, 1955));
            wetenschappers.Add(new Wetenschapper("Alexander Graham Bell", 1847, 1922));
            wetenschappers.Add(new Wetenschapper("Alfred Nobel", 1833, 1896));
            wetenschappers.Add(new Wetenschapper("Amedeo Avogadro", 1776, 1856));
            wetenschappers.Add(new Wetenschapper("André - Marie Ampère", 1775, 1836));
            wetenschappers.Add(new Wetenschapper("Antoine Henri Becquerel", 1852, 1908));
            wetenschappers.Add(new Wetenschapper("Antoine Lavoisier", 1743, 1794));
            wetenschappers.Add(new Wetenschapper("Blaise Pascal", 1623, 1662));
            wetenschappers.Add(new Wetenschapper("Carl Friedrich Gauss", 1777, 1855));
            wetenschappers.Add(new Wetenschapper("Carl Sagan", 1934, 1996));
            wetenschappers.Add(new Wetenschapper("Charles Darwin", 1809, 1882));
            wetenschappers.Add(new Wetenschapper("Charles - Augustin de Coulomb", 1736, 1806));
            wetenschappers.Add(new Wetenschapper("Edwin Hubble", 1889, 1953));
            wetenschappers.Add(new Wetenschapper("Enrico Fermi", 1901, 1954));
            wetenschappers.Add(new Wetenschapper("Evangelista Torricelli", 1608, 1647));
            wetenschappers.Add(new Wetenschapper("Francis Crick", 1916, 2004));
            wetenschappers.Add(new Wetenschapper("Galileo Galilei", 1564, 1642));
            wetenschappers.Add(new Wetenschapper("Gottfried Wilhelm Leibniz", 1646, 1716));
            wetenschappers.Add(new Wetenschapper("Gregor Mendel", 1822, 1884));
            wetenschappers.Add(new Wetenschapper("Guglielmo Marconi", 1874, 1937));
            wetenschappers.Add(new Wetenschapper("Heinrich Hertz", 1857, 1894));
            wetenschappers.Add(new Wetenschapper("Isaac Newton", 1642, 1727));
            wetenschappers.Add(new Wetenschapper("James Clerk Maxwell", 1831, 1879));
            wetenschappers.Add(new Wetenschapper("James Prescott Joule", 1818, 1889));
            wetenschappers.Add(new Wetenschapper("Johannes Kepler", 1571, 1630));
            wetenschappers.Add(new Wetenschapper("John Dalton", 1766, 1844));
            wetenschappers.Add(new Wetenschapper("John von Neumann", 1903, 1957));
            wetenschappers.Add(new Wetenschapper("Leonardo da Vinci", 1452, 1519));
            wetenschappers.Add(new Wetenschapper("Leonhard Euler", 1707, 1783));
            wetenschappers.Add(new Wetenschapper("Louis Pasteur", 1822, 1895));
            wetenschappers.Add(new Wetenschapper("Ludwig Boltzmann", 1844, 1906));
            wetenschappers.Add(new Wetenschapper("Marie Curie", 1867, 1934));
            wetenschappers.Add(new Wetenschapper("Max Planck", 1858, 1947));
            wetenschappers.Add(new Wetenschapper("Michael Faraday", 1791, 1867));
            wetenschappers.Add(new Wetenschapper("Nicolaas Copernicus", 1473, 1543));
            wetenschappers.Add(new Wetenschapper("Niels Bohr", 1885, 1962));
            wetenschappers.Add(new Wetenschapper("Nikola Tesla", 1856, 1943));
            wetenschappers.Add(new Wetenschapper("Paul Dirac", 1902, 1984));
            wetenschappers.Add(new Wetenschapper("Pierre Curie", 1859, 1906));
            wetenschappers.Add(new Wetenschapper("René Descartes", 1596, 1650));
            wetenschappers.Add(new Wetenschapper("Robert Boyle", 1627, 1691));
            wetenschappers.Add(new Wetenschapper("Subramanyan Chandrasekhar", 1910, 1995));
            wetenschappers.Add(new Wetenschapper("Wilhelm Röntgen", 1845, 1923));
            wetenschappers.Add(new Wetenschapper("William Thomson", 1824, 1907));
        }

        public int MostAlive()
        {
            int MinAge = 99999;
            int MaxAge = 0;
            foreach (var wetenschapper in wetenschappers)
            {
                if (wetenschapper.AgeOfBirth < MinAge)
                {
                    MinAge = wetenschapper.AgeOfBirth;
                }
                if (wetenschapper.AgeOfDeath > MaxAge)
                {
                    MaxAge = wetenschapper.AgeOfDeath;
                }
            }

            Dictionary<int, int> years = new Dictionary<int, int>();
            for (int i = MinAge; i < MaxAge; i++)
            {
                years.Add(i, 0);
            }

            foreach (var wetenschapper in wetenschappers)
            {
                for (int i = wetenschapper.AgeOfBirth; i < wetenschapper.AgeOfDeath; i++)
                {
                    years[i] = years[i] + 1;
                }
            }

            int maxYear = 0;
            int odlValue = 0;
            foreach (var year in years)
            {
                if (year.Value > odlValue)
                {
                    odlValue = year.Value;
                    maxYear = year.Key;
                }
            }

            return maxYear;
        }
    }
}
