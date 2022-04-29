using NUnit.Framework;
using TestEY;

namespace TestSolution
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var text = "we the people of the united states in order to form a more perfect union etc";

            var result = ModifiedText.GetModifiedText(text);
            Assert.AreEqual("wpuadmro elnteafn teiermee hotstoct efeiortc ptdnfeu ehsoopn oetrrei ", result);
        }

        [Test]
        public void Test2()
        {
            var text = "cheating is not allowed";

            var result = ModifiedText.GetModifiedText(text);
            Assert.AreEqual("ctit hisa ennl agol ", result);
        }

        [Test]
        public void Test3()
        {
            var text = "the rocks";

            var result = ModifiedText.GetModifiedText(text);
            Assert.AreEqual("trk hos ec ", result);
        }
        [Test]
        public void Test4()
        {
            var text = "Hello World";

            var result = ModifiedText.GetModifiedText(text);
            Assert.AreEqual("Hlo eor lWl ", result);
        }
    }
}