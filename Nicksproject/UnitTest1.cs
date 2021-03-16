using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Nicksproject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public static bool IsAnagram(string str1, string str2)
        {
            int count = 0;
            int secondCount = 0;
            bool anagram = false;

            for(int i = 0; i < str1.Length - 1; i++)
            {
                count++;
                secondCount = str2.Length - 1;

                if(str2.Contains(str1[i]) && count == secondCount)
                {
                    anagram = true;
                }
            }

            return anagram;
            Console.WriteLine(anagram);
        }
    }
}
