using System.Collections.Generic;
using NUnit.Framework;
using FluentAssertions;
using Social.Friends;
using System;

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
            sut.List.Add(
                new FriendBuilder()
                    .WithId(1)
                    .WithName("a")
                    .WithOnlineStatus(false)
                    .WithLastSeen(new DateTime(2008, 12, 2))
                    .WithLevel(1)
                    .Build()
                );
        }
    }

    public class FriendBuilder
    {
        int _id;
        string _name;
        bool _isOnline;
        DateTime _lastSeen;
        int _level;

        public FriendBuilder WithId(int id)
        {
            _id = id;
            return this;
        }

        public FriendBuilder WithName(string name)
        {
            _name = name;
            return this;
        }

        public FriendBuilder WithOnlineStatus(bool isOnline)
        {
            _isOnline = isOnline;
            return this;
        }

        public FriendBuilder WithLastSeen(DateTime lastSeen)
        {
            _lastSeen = lastSeen;
            return this;
        }

        public FriendBuilder WithLevel(int level)
        {
            _level = level;
            return this;
        }

        public Friend Build()
        {
            return new Friend(_id, _name, _isOnline, _lastSeen, _level);
        }
    }
}
