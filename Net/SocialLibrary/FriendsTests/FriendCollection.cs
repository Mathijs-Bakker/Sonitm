using NUnit.Framework;
using FluentAssertions;

namespace sutsTests
{
    [TestFixture]
    public class sutCollection
    {
        [Test]
        public void Sut_Is_TypeOf_sut()
        {
            var sut = new Friend();
            sut.Should().BeOfType<Friend>();
        }
        
        [Test]
        public void Test()
        {
            
        }
    }

    public struct Friend
    {}
}
