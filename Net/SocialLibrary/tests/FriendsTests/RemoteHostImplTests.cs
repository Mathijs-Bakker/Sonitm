using System.Collections.Generic;
using NUnit.Framework;
using FluentAssertions;
using Social.Friends;

namespace FriendsTests
{
    [TestFixture]
    public class RemoteHostImplTests
    {
        [Test]
        public void Sut_Should_Have_Friends_Collection()
        {
            RemoteHost sut = new RemoteHostImpl();
            sut.Friends.Count.Should().Be(1);
        }
    }
}
