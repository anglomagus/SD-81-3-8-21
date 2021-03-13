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
            else
            {
                Console.WriteLine("You're still a kid");
            }
        }
    }
}
