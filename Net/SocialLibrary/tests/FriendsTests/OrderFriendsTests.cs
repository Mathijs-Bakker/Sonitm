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
                    .WithLastSeen(new DateTime(0001, 1, 4))
                    .WithLevel(2)
                    .Build(),

                new FriendBuilder()
                    .WithId(1)
                    .WithName("b")
                    .WithOnlineStatus(false)
                    .WithLastSeen(new DateTime(0001, 1, 1))
                    .WithLevel(1)
                    .Build(),

                new FriendBuilder()
                    .WithId(3)
                    .WithName("d")
                    .WithOnlineStatus(false)
                    .WithLastSeen(new DateTime(0001, 1, 2))
                    .WithLevel(4)
                    .Build(),

                new FriendBuilder()
                    .WithId(2)
                    .WithName("a")
                    .WithOnlineStatus(false)
                    .WithLastSeen(new DateTime(0001, 1, 3))
                    .WithLevel(3)
                    .Build()
                };

        [Test]
        public void By_Methods__Take_And_Return_A_List_of_Friends()
        {
            OrderFriends.ByName(new List<Friend>()).Should().BeOfType<List<Friend>>();
            OrderFriends.ByOnlineStatus(new List<Friend>()).Should().BeOfType<List<Friend>>();
            OrderFriends.ByLastSeen(new List<Friend>()).Should().BeOfType<List<Friend>>();
            OrderFriends.ByLevel(new List<Friend>()).Should().BeOfType<List<Friend>>();
        }

        [Test]
        public void ByName__Sort_Friends_By_Name_Alphabetically()
        {
            var newFriendsOrder = OrderFriends.ByName(_friends);
            newFriendsOrder.Should().BeInAscendingOrder(friend => friend.Name);
        }

        [Test]
        public void ByOnlineStatus__Sort_By_Online_Friends_First()
        {
            var newFriendsOrder = OrderFriends.ByOnlineStatus(_friends);
            newFriendsOrder.Should().BeInAscendingOrder(friend => friend.IsOnline);
        }

        [Test]
        public void ByLastSeen__Sort_By_Most_Recent_First()
        {
            var newFriendsOrder= OrderFriends.ByLastSeen(_friends);
            newFriendsOrder.Should().BeInAscendingOrder(friend => friend.LastSeen);
        }

        [Test]
        public void ByLevel__Sort_By_Highest_Level_First()
        {
            var newFriendsOrder = OrderFriends.ByLevel(_friends);
            newFriendsOrder.Should().BeInAscendingOrder(friend => friend.Level);
        }
    }
}
