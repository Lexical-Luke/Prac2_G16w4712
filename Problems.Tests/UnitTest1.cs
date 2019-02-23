using NUnit.Framework;
using Problems;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void nullTest()
        {
            string a = Program.prefix(null);
            Assert.That(a,Is.Null);
            //Assert.IsTrue(result, "Did not output correctly");
        }

        [Test]
        public void helloTest()
        {
            bool a = (Program.prefix("hello") == "5,1:hello");
            Assert.That(a,Is.True);
        }
 
        [Test]
        public void emptyTest()
        {
            bool a = (Program.prefix("") == "0,0:");
            Assert.That(a,Is.True);
        }
        [Test]
        public void stringTest()
        {
            bool a = (Program.prefix("what   ...  did you say??  ") == "27,5:what   ...  did you say??  ");
            Assert.That(a,Is.True);
        }

    }
}