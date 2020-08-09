using System.Collections.Generic;
using NUnit.Framework;
using FluentAssertions;
using Social.Friends;

namespace FriendsTests
{
    [TestFixture]
    public class RemoteHostTests
    {
        [Test]
        public void Sut_Should_Have_an_Observable_Friends_Collection()
        {
           IRemoteHost sut = new RemoteHost();

           //sut.Should().BeOfType<IRemoteHost>();
           sut.FriendsList.Should().BeOfType<List<Friend>>();
        }
    }
}
