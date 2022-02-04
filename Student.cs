using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallels
{
    class Student
    {
        public string name;
        public string major; // специальность
        public double gpa;   // средний бал

        public Student(string aName, string aMajor, double Agpa)
        {
            name = aName;
            major = aMajor;
            gpa = Agpa;
        }

        public bool hasHonors()
        {
            if(gpa>= 3)
            {
                return true;
            }
            return false;

        }

    }

}
