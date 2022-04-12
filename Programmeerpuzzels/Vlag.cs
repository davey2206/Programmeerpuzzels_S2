using System;
using System.Collections.Generic;

namespace Programmeerpuzzels
{
    public class Vlag
    {
        public List<string> Colors = new List<string>();
        public void Generate()
        {
            Random rng = new Random();
            int j = rng.Next(4, 20);

            for (int i = 0; i < j; i++)
            {

                if (rng.Next(2) == 1)
                {
                    Colors.Add("Rood");
                }
                else
                {
                    Colors.Add("Wit");
                }
            }
        }

        public void SortVlag()
        {
            int n = Colors.Count;
            for (int i = 1; i < n; ++i)
            {
                string key = Colors[i];
                int j = i - 1;

                while (j >= 0 && Colors[j] != "Rood")
                {
                    Colors[j + 1] = Colors[j];
                    j = j - 1;
                }
                Colors[j + 1] = key;
            }
        }
    }
}
