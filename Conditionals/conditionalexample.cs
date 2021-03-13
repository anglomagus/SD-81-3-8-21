using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Conditionals
{
    [TestClass]
    public class conditionalexample
    {
        [TestMethod]
        public void Booleans()
        {
            bool isTrue = 17 > 5;
            bool isFalse = 17 == 4;
        }

        [TestMethod]
        public void IfElseStatements()
        {
            bool isTrue = true;
            if(isTrue)
            { 
                //Do something here
            }

            int age = 12;
            if (age > 17)
            {
                Console.WriteLine("You're an adult");
            }
           else if (age > 6)
            {
                Console.WriteLine("You're a kid");
            }
            else if (age > 0)
            {
                Console.WriteLine("You're far too young to be on a computer");
            }

            if (age > 65 && age < 18)
            {
                // And comparison &&
            }

            if (age <= 65 || age >= 18)
            {
                // Or comparson ||
            }

            if (age == 17)
            {
                // Is equal to
            }

            if (age != 19)
            {
                // Not equals to
            }
        }

        [TestMethod]
        public void switchCases()
        {
            int age = 42;

            switch (age)
            {
                case 18:
                    //Code for if age is 18 etc..
                    break;
                case 19:
                    break;
                case 20:
                    break;
                case 21:
                case 22:
                case 23:
                    // Code ehre for 21-23
                    break;
                default:
                    //Catch all code
                    Console.WriteLine("You are not 18-23");
                    break;
            }
        }

        [TestMethod]
        public void Ternaries()
        {
            int age = 37;

            // Variable = (boolean statement) ? trueValue : falseValue;

            bool isAge = (age == 24) ? true : false;
        }

    }
}
