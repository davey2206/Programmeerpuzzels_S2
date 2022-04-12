using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmeerpuzzels
{
    public class Wetenschapper
    {
        public Wetenschapper(string name, int ageOfBirth, int ageOfDeath)
        {
            this.Name = name;
            this.AgeOfBirth = ageOfBirth;
            this.AgeOfDeath = ageOfDeath;
        }

        public string Name { get; }
        public int AgeOfBirth { get; }
        public int AgeOfDeath { get; }
    }
}
