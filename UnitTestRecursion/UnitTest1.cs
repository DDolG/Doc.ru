using Microsoft.VisualStudio.TestPlatform.TestHost;
using Doc.Ru.Programs.Recursion;
using ProgramRecursion = Doc.Ru.Programs.Recursion.Program;
using NUnit.Framework;

namespace UnitTestRecursion
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase((uint)17, (uint)8)]
        [TestCase((uint)16, (uint)7)]
        [TestCase((uint)942, (uint)6)]
        public void TestCalculationRecursion(uint number, uint expected)
        {
            var result = ProgramRecursion.GetRecursionNumb(number);
            Assert.AreEqual(expected, result);
        }
    }
}