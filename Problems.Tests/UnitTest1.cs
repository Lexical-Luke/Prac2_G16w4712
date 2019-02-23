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
        public void singleTest()
        {
            string a = Program.prefix(null);
            Assert.That(a,Is.Null);
            bool b = (Program.prefix("hello") == "5,1:hello");
            Assert.That(b,Is.True);
            bool c = (Program.prefix("") == "0,0:");
            Assert.That(c,Is.True);
            bool d = (Program.prefix("what   ...  did you say??  ") == "27,5:what   ...  did you say??  ");
            Assert.That(d,Is.True);


            bool e = (Program.prefix("      ") == "6,1:      ");
            Assert.That(e,Is.True);
            bool f = (Program.prefix("/...s /.w,w ./m12 ?`` ~~") == "24,5:/...s /.w,w ./m12 ?`` ~~");
            Assert.That(f,Is.True);
            bool g = (Program.prefix("01029 10293") == "11,2:01029 10293");
            Assert.That(g,Is.True);
        }

    }
}