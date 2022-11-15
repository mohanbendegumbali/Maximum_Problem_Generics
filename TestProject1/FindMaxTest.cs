using FindMaximumNumber;

namespace TestProject1
{
    public class Tests
    {
        FindMaxNum maxString = new FindMaxNum();
        [SetUp]

        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFirstMax()
        {
            int result = maxString.FindMaxInteger(15, 5, 10);
            Assert.AreEqual(15, result);
        }

        [Test]
        public void GivenMaxsecondNum_WhenAnalysed_ShouldReturnSecondMax()
        {
            int result = maxString.FindMaxInteger(10, 15, 5);
            Assert.AreEqual(15, result);
        }

        [Test]
        public void GivenMaxThirdNum_WhenAnalysed_ShouldReturnThirdMax()
        {
            int result = maxString.FindMaxInteger(10, 5, 15);
            Assert.AreEqual(15, result);
        }
    }
}

 