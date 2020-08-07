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
        public void Sut_Should_Have_a_Name_Poperty_OfType_String()
        {
            var sut = new Friend("a");
            sut.Name.Should().BeOfType<string>();
            sut.Name.Should().Be("a");
        }
    }

    public struct Friend
    {
        public string Name { get; private set; }

        public Friend (string name)
        {
            Name = name;
        }
    }
}
