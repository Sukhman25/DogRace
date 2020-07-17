using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogRace
{
    public static class Factory
    {
        public static int count = 0;
        // Decides which class to instantiate
        public static Punter GetAPunter(int id)
        {
            switch (id)
            {
                case 0:
                    {
                        count++;
                        return new Shivam();
                    }
                case 1:
                    {
                        count++;
                        return new Sukhpal();
                    }
                case 2:
                    {
                        count++;
                        return new Gurlal();
                    }
                default: return null;
            }
        }
    }
}
