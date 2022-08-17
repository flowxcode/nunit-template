using ClassLibrary1;

namespace TestProject1
{
    [TestFixture]
    public class PrimeService_IsPrimeShould
    {
        private ClassX _primeService;

        public PrimeService_IsPrimeShould()
        {
            TestContext.Progress.WriteLine("x ctor PrimeService_IsPrimeShould");
        }

        [OneTimeSetUp]
        public void OneTimeSetUp() => TestContext.Progress.WriteLine("x OneTimeSetUp");

        [SetUp]
        public void SetUp()
        {
            TestContext.Progress.WriteLine("x SetUp");
            _primeService = new ClassX();
        }

        [Test]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            TestContext.Progress.WriteLine("x IsPrime_InputIs1_ReturnFalse");
            var result = _primeService.IsPrime(1);

            Assert.IsFalse(result, "1 should not be prime");
        }

        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
        {
            TestContext.Progress.WriteLine("x IsPrime_ValuesLessThan2_ReturnFalse");
            var result = _primeService.IsPrime(value);

            Assert.IsFalse(result, $"{value} should not be prime");
        }
    }
}