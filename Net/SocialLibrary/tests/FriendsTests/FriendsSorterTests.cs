using NUnit.Framework;
using FluentAssertions;
using Social.Friends;
using System;
using System.Collections.Generic;

namespace FriendsTests
{
    public class FriendsSorterTests
    {
        OrderFriends _sut;

        List<Friend> _friends = new List<Friend>(){
                new FriendBuilder()
                    .WithId(4)
                    .WithName("c")
                    .WithOnlineStatus(false)
                    .WithLastSeen(new DateTime(0001, 1, 1))
                    .WithLevel(0)
                    .Build(),

                new FriendBuilder()
                    .WithId(1)
                    .WithName("b")
                    .WithOnlineStatus(false)
                    .WithLastSeen(new DateTime(0001, 1, 1))
                    .WithLevel(0)
                    .Build(),

                new FriendBuilder()
                    .WithId(3)
                    .WithName("d")
                    .WithOnlineStatus(false)
                    .WithLastSeen(new DateTime(0001, 1, 1))
                    .WithLevel(0)
                    .Build(),

                new FriendBuilder()
                    .WithId(2)
                    .WithName("a")
                    .WithOnlineStatus(false)
                    .WithLastSeen(new DateTime(0001, 1, 1))
                    .WithLevel(0)
                    .Build()
                };

        [SetUp]
        public void SetUp()
        {
            _sut = new OrderFriends();
        }

        [Test]
        public void SortMethods_Should_Take_And_Return_A_List_of_Friends()
        {
            _sut.SortByName(new List<Friend>()).Should().BeOfType<List<Friend>>();
            _sut.SortByOnlineStatus(new List<Friend>()).Should().BeOfType<List<Friend>>();
            _sut.SortByLastSeen(new List<Friend>()).Should().BeOfType<List<Friend>>();
            _sut.SortByLevel(new List<Friend>()).Should().BeOfType<List<Friend>>();
        }

        [Test]
        public void SortByName_Should_Sort_Friends_By_Name_Ascending()
        {
            var sortedFriends = _sut.SortByName(_friends);
            sortedFriends.Should().BeInAscendingOrder(friend => friend.Name);
        }

        [Test]
        public void SortByOnlineStatus_Should_Sort_Friends_By_OnlineStatus()
        {
            var sortedByOnlineStatus = _sut.SortByOnlineStatus(_friends);
            sortedByOnlineStatus.Should().BeInAscendingOrder(friend => friend.IsOnline);
        }

        [Test]
        public void SortByLastSeen_Should_Sort_Friends_By_LastSeen()
        {
            var sortedByDateTime = _sut.SortByName(_friends);
            sortedByDateTime.Should().BeInAscendingOrder(friend => friend.LastSeen);
        }

        [Test]
        public void SortByLevel_Should_Sort_Friends_By_LastSeen()
        {
            var sortedByLevel = _sut.SortByName(_friends);
            sortedByLevel.Should().BeInAscendingOrder(friend => friend.Level);
        }

    }
}
