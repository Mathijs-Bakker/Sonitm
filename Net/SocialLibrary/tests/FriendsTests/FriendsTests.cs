using System.Collections.Generic;
using NUnit.Framework;
using NSubstitute;
using FluentAssertions;
using Social.Friends;
using System;
using System.Collections.ObjectModel;

namespace FriendsTests
{
    [TestFixture]
    public class FriendsTests
    {
        Friends _sut;

        RemoteHost _remoteHost;
        ObservableCollection<Friend> _observableFriends; 

        [SetUp]
        public void SetUp()
        {
            
            _remoteHost = Substitute.For<RemoteHost>();

            _sut = new Friends(_remoteHost);

            _observableFriends = new ObservableCollection<Friend>();
            _observableFriends.Add(
                    new FriendBuilder()
                        .WithId(0)
                        .WithName("")
                        .WithOnlineStatus(false)
                        .WithLastSeen(new DateTime(0001, 1, 1))
                        .WithLevel(0)
                        .Build()
                    );
             
            _remoteHost.Friends.Returns(_observableFriends);
        }

        [Test]
        public void Friends_Listing_Should_BeOFType_ListFriend()
        {
            _sut.List.Should().BeOfType<List<Friend>>();
        }         
       
        [Test]
        public void When_Sut_Is_Instantiated___List_Should_Count_0()
        {
            _sut.List.Count.Should().Be(0);
        }

        [Test]
        public void When_Calling_Update___List_Should_Have_One_Entry()
        {
            _sut.Update();
            _sut.List.Count.Should().Be(1);
        }
        
        [Test]
        public void When_FriendsCollectionChanged___Update_Should_BeCalled()
        {

            _sut.Update();
            
            _remoteHost.Friends.Add(
                new FriendBuilder()
                    .WithId(1)
                    .WithName("a")
                    .WithOnlineStatus(false)
                    .WithLastSeen(new DateTime(0001, 1, 1))
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
