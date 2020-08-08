using System.Collections.Generic;
using NUnit.Framework;
using FluentAssertions;

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
        
        [Test]
        public void Sut_Should_Have_a_Name_Poperty_OfType_String()
        {
            var sut = new Friend(0, "a");
            sut.Name.Should().BeOfType<string>();
            sut.Name.Should().Be("a");
        }

        [Test]
        public void Sut_Should_Have_an_Id_Property_OfType_Int()
        {
            var sut = new Friend(1, "");
            sut.Id.Should().BeOfType(typeof(int));
            sut.Id.Should().Be(1);
        }
    }
    
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
        public void tjjT()
        {
            var sut = new Friends();
            sut.List.Should().BeOfType<List<Friend>>();
        }         
// When friend status changes on remote the List should be updated
// Add a observable helper class on remote

        [Test]
        public void Update_Should_()
        {
            var sut = new Friends();
            sut.List.Add(new Friend(0, "a"));
            
//             sut.Update();

            
            
        }
    }

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

    public class Friends
    {
        public IList<Friend> List = new List<Friend>();
            
    }

    public interface IRemoteHost
    {
        List<Friend> FriendsList { get; }
    }

    public class RemoteHost : IRemoteHost
    {
        public List<Friend> FriendsList { get; private set; }
    }

    public struct Friend
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Friend (int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
