using NUnit.Framework;
using ProgramNumberConverter = Doc.Ru.Programs.ChangeNumber.Program;

namespace TestChangeNumber
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase((uint)42145, (uint)54421)]
        public void Test1(uint inputNumber, uint expected)
        {
            var result = ProgramNumberConverter.ConvertNumber(inputNumber);
            Assert.AreEqual(expected, result);
        }
    }
}