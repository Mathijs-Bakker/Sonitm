using System.Collections.Generic;
using NUnit.Framework;
using FluentAssertions;
using Social.Friends;

namespace FriendsTests
{
    [TestFixture]
    public class FriendsTests
    {
        [Test]
        public void Sut_Should_BeOfType_Friends()
        {
            var sut = new Friends();
            sut.Should().BeOfType<Friends>();
        }
        
        [Test]
        public void Friends_Listing_Should_BeOFType_ListFriend()
        {
            var sut = new Friends();
            sut.List.Should().BeOfType<List<Friend>>();
        }         

        [Test]
        public void Update_Should_()
        {
            var sut = new Friends();
            sut.List.Add(new Friend(0, "a"));
        }
    }
}
