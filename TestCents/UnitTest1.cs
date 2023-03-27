using NUnit.Framework;
using Doc.Ru.Programs.Cents;
using ProgramCents = Doc.Ru.Programs.Cents.Program;

namespace TestCents
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("56",(uint)1, (uint)1, (uint)0, (uint)2)]
        [TestCase("-435", (uint)0, (uint)0, (uint)0, (uint)0)]
        [TestCase("4,935", (uint)0, (uint)4, (uint)0, (uint)0)]
        public void Test1(string cents, uint nikels, uint pennies, uint dimes, uint quarters)
        {
            var result = ProgramCents.ConvertCentsToDifferentCoins(cents);
            Assert.AreEqual(result["Nikels"], nikels);
            Assert.AreEqual(result["Pennies"], pennies);
            Assert.AreEqual(result["Dimes"], dimes);
            Assert.AreEqual(result["Quarters"], quarters);
        }
    }
}