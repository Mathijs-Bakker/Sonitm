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
           RemoteHost sut = new RemoteHostImpl();

           //sut.Should().BeOfType<IRemoteHost>();
        }
    }
}
