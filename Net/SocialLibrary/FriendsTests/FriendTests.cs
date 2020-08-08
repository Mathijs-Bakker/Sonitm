using NUnit.Framework;
using FluentAssertions;

namespace FriendsTests
{
    [TestFixture]
    public class FriendTests
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
            var sut = new Friend(0, "a");
            sut.Name.Should().BeOfType<string>();
            sut.Name.Should().Be("a");
        }

        [Test]
        public void Sut_Should_Have_an_Id_Property_OfType_Int()
        {
            var sut = new Friend(1, "");
            sut.Id.Should().BeOfType(typeof(int));
            sut.Id.Should().Be(1);
        }
    }

    public struct Friend
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Friend (int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
