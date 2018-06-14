using System;
using System.Collections.Generic;
using System.IO;
using static System.Console;

namespace ClassandInheritance
{
    class Person {
        public int age;     
        public Person(int initialAge)
        {
            // Add some more code to run some checks on initialAge
            if(initialAge < 0)
            {
                this.age  = 0;
                WriteLine("Age is not valid, setting age to 0.");
            }
            else
            {
                this.age = initialAge;
            }
        }
        public void amIOld()
        {
            // Do some computations in here and print out the correct statement to the console 
            if(age >= 18)
            {
                WriteLine("You are old.");
            }
            if((age >= 13) && (age < 18))
            {
                WriteLine("You are a teenager.");
            }
            if(age < 13)
            {
                WriteLine("You are young.");
            }
        }

        public void yearPasses()
        {
            // Increment the age of the person in here
            age++;
        }
    }
}
