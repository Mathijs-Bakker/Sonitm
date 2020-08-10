using NUnit.Framework;
using FluentAssertions;
using Social.Friends;
using System;

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
    }
}
