using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public class People
    {
        string name;
        int age;
        bool pregnant;

        public People(string aName, int dAge, bool isPregnant)
        {
            name = aName;
            age = dAge;
            pregnant = isPregnant;
        }

        public bool HasPregnant()
        {
            if (pregnant == true)
            {
                Console.WriteLine($"congratulation {name} you are pregnant");
                return true;
            }
            return false;
        }

    }
}