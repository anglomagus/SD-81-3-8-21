using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace conditionsandloopchallenge
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string myName = "Supercalifragilisticexpialidocious";
            foreach (char letter in myName)
            {
                    Console.WriteLine(letter);
            }

            string myName2 = "Supercalifragilisticexpialidocious";
            foreach (char i in myName)
            {
                if (i == 'i')
                {
                    Console.WriteLine(i);
                }
               if (i != 'i')
                {
                    Console.WriteLine("not an i");
                }
                if (i == 'l')
                {
                    Console.WriteLine("L");
                }
            }

        }
    }
}
