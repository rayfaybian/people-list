using System;
using System.Collections.Generic;
using System.Text;

namespace MeineErsteApp
{
    public class Person
    {
        public string name;
        public int age;
        public string city;
        public string Job;

        override public String ToString()
        {
            return name + ";" + age + ";" + city + ";" + Job;
        }
    }
}
