using FindMaximumNumber;

namespace TestProject1
{
    public class Tests
    {
        FindMaxNum maxString = new FindMaxNum();
        [SetUp]

        public void GivenMaxFirstString_WhenAnalysed_ShouldReturnFirstMax()
        {
            string result = maxString.FindMaxString("Peach","Apple","Banana");
            Assert.AreEqual("Peach", result);
        }

        [Test]
        public void GivenMaxsecondString_WhenAnalysed_ShouldReturnSecondMax()
        {
            string result = maxString.FindMaxString("Apple","Peach","Banana");
            Assert.AreEqual("Peach", result);
        }

        [Test]
        public void GivenMaxThirdString_WhenAnalysed_ShouldReturnThirdMax()
        {
            string result = maxString.FindMaxString("Apple","Banana","Peach");
            Assert.AreEqual("Peach", result);
        }
    }
}

 