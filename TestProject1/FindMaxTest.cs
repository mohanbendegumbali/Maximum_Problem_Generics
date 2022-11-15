using FindMaximumNumber;

namespace TestProject1
{
    public class Tests
    {
        FindMaxNum maxString = new FindMaxNum();
        FindMaxGeneric <int> generic1 = new FindMaxGeneric<int>();
        FindMaxGeneric<float> generic2 = new FindMaxGeneric<float>();
        FindMaxGeneric<string> generic3 = new FindMaxGeneric<string>();
        [SetUp]

        public void GivenMaxFirstString_WhenAnalysed_ShouldReturnFirstMax()
        {
            string result = generic3.FindMax("Peach","Apple","Banana");
            Assert.AreEqual("Peach", result);
        }

        [Test]
        public void GivenMaxsecondString_WhenAnalysed_ShouldReturnSecondMax()
        {
            string result = generic3.FindMax("Apple","Peach","Banana");
            Assert.AreEqual("Peach", result);
        }

        [Test]
        public void GivenMaxThirdString_WhenAnalysed_ShouldReturnThirdMax()
        {
            string result = generic3.FindMax("Apple","Banana","Peach");
            Assert.AreEqual("Peach", result);
        }
        [Test]
        public void GivenMaxFirstInteger_WhenAnalysed_ShouldReturnFirstMax()
        {
            int result = generic1.FindMax(15, 10, 5);
            Assert.AreEqual(15, result);
        }
        [Test]
        public void GivenMaxSecondInteger_WhenAnalysed_ShouldReturnSecondMax()
        {
            int result = generic1.FindMax(10, 15, 5);
            Assert.AreEqual(15, result);
        }
        [Test]
        public void GivenMaxThirdInteger_WhenAnalysed_ShouldReturnThirdMax()
        {
            int result = generic1.FindMax(5, 10, 15);
            Assert.AreEqual(15, result);
        }
        [Test]
        public void GivenMaxFirstFloat_WhenAnalysed_ShouldReturnFirstMax()
        {
            float result = generic2.FindMax(5.7F, 5.6F, 5.5F);
            Assert.AreEqual(5.7F, result);
        }
        [Test]
        public void GivenMaxSecondFloat_WhenAnalysed_ShouldReturnSecondMax()
        {
            float result = generic2.FindMax(5.6F, 5.7F, 5.5F);
            Assert.AreEqual(5.7F, result);
        }
        [Test]
        public void GivenMaxThirdFloat_WhenAnalysed_ShouldReturnthirdMax()
        {
            float result = generic2.FindMax(5.5F, 5.6F, 5.7F);
            Assert.AreEqual(5.7F, result);
        }
    }
}

 