using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public class Student
    {
        public string name;
        public string major;
        double gpa;

       public Student(string aName, string aMajor, double aGpa)
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;
        }

       public bool HasHonnors()
        {
            if (gpa >= 3.5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}