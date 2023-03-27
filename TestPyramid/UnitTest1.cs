using NUnit.Framework;
using ProgramPyramid = Doc.Ru.Programs.Pyramid.Program;

namespace TestPyramid
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase((uint)1, (uint)1)]
        [TestCase((uint)2, (uint)8)]
        public void Test1(uint inputNumber, uint expected )
        {
            var result = ProgramPyramid.GetPyramidRowSumm(inputNumber);
            Assert.AreEqual(expected, result);
        }
    }
}