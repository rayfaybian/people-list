using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace MeineErsteApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myFileContent = System.IO.File.ReadAllLines("C:\\Coding\\C#\\PeopleList\\Files\\people.txt");
            string[] strArray;

            int counter = 0;
            foreach (string element in myFileContent)
            {
                strArray = element.Split(";");

                Person person = new Person();
                person.name = strArray[0];
                person.age = int.Parse(strArray[1]);
                person.city = strArray[2];

                if (person.name.StartsWith("H"))
                {
                    person.Job = "Coder";
                }
                else
                {
                    person.Job = "Officer";
                }

                Console.WriteLine("Name: " + person.name + "\nAge: " + person.age + "\nCity: " + person.city + "\nJob: " + person.Job + "\n");

                myFileContent[counter] = person.ToString();
                counter++;

            }

            System.IO.File.WriteAllLines("C:\\Coding\\C#\\PeopleList\\Files\\peopleNEW.txt", myFileContent);
        }
    }
}
