using System.Collections.Generic;
using NUnit.Framework;
using FluentAssertions;
using Social.Friends;

namespace FriendsTests
{
    [TestFixture]
    public class FriendTests
    {
        [Test]
        public void Sut_Is_TypeOf_Friend()
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
}    
