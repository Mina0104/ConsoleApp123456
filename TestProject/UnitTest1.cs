using NUnit.Framework;
using ConsoleApp123456;
namespace TestProject
{
    public class UnitTest1
    {
        [TestCase(4, 2, -12)]
        public void DelenieTest(int a, int b, double expected)
        {
            double actual = Primeri.Delenie(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10,7,17)]
        [TestCase(17,17,289)]
        [TestCase(6,11,-5)]
        public void PodsctitatTest(int a, int b, int expected)
        {
            int actual = Primeri.Podsctitat(a, b);
            Assert.AreEqual(expected, actual);



        }

    }
}

    


   










 