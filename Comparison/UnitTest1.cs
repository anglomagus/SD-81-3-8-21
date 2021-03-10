using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Comparison
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ComparisonOperators()
        {
            int age = 25;
            string userName = "Nick";

            bool equals = age == 29;
            Console.WriteLine(equals);

            bool userIsNick = userName == "Terry";
            Console.WriteLine(userIsNick);
            Console.WriteLine("User is 29:" + equals);

            bool notEqual = age != 122;
            Console.WriteLine(notEqual);

            bool userIsNotJustin = userName != "Justin";
            Console.WriteLine(userIsNotJustin);

            List<string> firstList = new List<string>();
            firstList.Add(userName);

            List<string> secondList = new List<string>();
            secondList.Add(userName);

            bool greaterThan = age > 12;

            bool greaterThanOrEqual = age >= 24;
            Console.WriteLine(greaterThanOrEqual);

            bool lessThan = age < 66;
            Console.WriteLine(lessThan);

            bool orValue = equals || lessThan;

            bool trueValue = true;
            bool falseValue = false;

            bool tOrT = trueValue || trueValue;
            bool tOrF = trueValue || falseValue;
            bool fOrT = falseValue || trueValue;
            bool fOrF = falseValue || falseValue;

            Console.WriteLine(tOrT);
            Console.WriteLine(tOrF);
            Console.WriteLine(fOrT);
            Console.WriteLine(fOrF);

            
        }
    }
}
