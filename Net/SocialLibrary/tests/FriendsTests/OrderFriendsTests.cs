using NUnit.Framework;
using FluentAssertions;
using Social.Friends;
using System;
using System.Collections.Generic;

namespace FriendsTests
{
    public class OrderFriendsTests
    {
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

        [Test]
        public void SortMethods_Should_Take_And_Return_A_List_of_Friends()
        {
            OrderFriends.ByName(new List<Friend>()).Should().BeOfType<List<Friend>>();
            OrderFriends.ByOnlineStatus(new List<Friend>()).Should().BeOfType<List<Friend>>();
            OrderFriends.ByLastSeen(new List<Friend>()).Should().BeOfType<List<Friend>>();
            OrderFriends.ByLevel(new List<Friend>()).Should().BeOfType<List<Friend>>();
        }

        [Test]
        public void SortByName_Should_Sort_Friends_By_Name_Ascending()
        {
            var newFriendsOrder = OrderFriends.ByName(_friends);
            newFriendsOrder.Should().BeInAscendingOrder(friend => friend.Name);
        }

        [Test]
        public void SortByOnlineStatus_Should_Sort_Friends_By_OnlineStatus()
        {
            var newFriendsOrder = OrderFriends.ByOnlineStatus(_friends);
            newFriendsOrder.Should().BeInAscendingOrder(friend => friend.IsOnline);
        }

        [Test]
        public void SortByLastSeen_Should_Sort_Friends_By_LastSeen()
        {
            var newFriendsOrder= OrderFriends.ByName(_friends);
            newFriendsOrder.Should().BeInAscendingOrder(friend => friend.LastSeen);
        }

        [Test]
        public void SortByLevel_Should_Sort_Friends_By_LastSeen()
        {
            var newFriendsOrder = OrderFriends.ByName(_friends);
            newFriendsOrder.Should().BeInAscendingOrder(friend => friend.Level);
        }

    }
}
