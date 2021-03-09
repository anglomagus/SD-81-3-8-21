using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ValueTypes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Booleans()
        {
            bool isDeclared;
            isDeclared = true;

            bool isDeclaredAndInitialized = false;

            isDeclaredAndInitialized = true;
        }
        [TestMethod]
        public void Characters ()
        {
            char character = 'a';
            char symbol = '?';
            char numbers = '7';
            char space = ' ';
            char specialCharacter = '\n';
        }
        [TestMethod]
        public void WholeNumbers()
        {
            byte byteExample = 255;
            sbyte sByteExample = 127;
            short shortExample = 32767;
            Int16 anotherShortExample = 32000;
            int intMin = 2147483647;
            Int32 intMax = 2147483647;
            long longExample = 934534534533453;
            int 64 longMin = -934534534533453;

                int a = 15;
            int b = -15;

            byte age = 25;
        }
      
        enum PastryType {  Cake, Cupcake, Eclaire, Petitfour, Croissant}
        [TestMethod]
        public void Enums()
        {
            PastryType myPastry = PastryType.Croissant;
            PastryType anotherOne = PastryType.Cake;
        }

        [TestMethod]
        public decimal Decimals()
        {
            float floatExample = 1.045231f;
            double doubleExample = 1.723423423426d;
            decimal decimalExample = 1.2578907289045789789789789787897m;


        }
        [TestMethod]
        public void Structs()
        {
            DateTime today = DateTime.Today;
            DateTime birthday = new DateTime(1991, 10, 4);

            Console.WriteLine(today);
        }
    }
}
