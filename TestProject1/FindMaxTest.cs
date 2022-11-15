using FindMaximumNumber;

namespace TestProject1
{
    public class Tests
    {
        FindMaxNum maxString = new FindMaxNum();
        [SetUp]

        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFirstMax()
        {
            float result = maxString.FindMaxFloat(5.7F, 5.6F, 5.5F);
            Assert.AreEqual(5.7F, result);
        }

        [Test]
        public void GivenMaxsecondNum_WhenAnalysed_ShouldReturnSecondMax()
        {
            float result = maxString.FindMaxFloat(5.5F, 5.7F, 5.6F);
            Assert.AreEqual(5.7F, result);
        }

        [Test]
        public void GivenMaxThirdNum_WhenAnalysed_ShouldReturnThirdMax()
        {
            float result = maxString.FindMaxFloat(5.6F, 5.5F, 5.7F);
            Assert.AreEqual(5.7F, result);
        }
    }
}

 