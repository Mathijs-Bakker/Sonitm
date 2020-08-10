using NUnit.Framework;
using FluentAssertions;
using Social.Friends;
using System.Collections.ObjectModel;

namespace FriendsTests
{
    [TestFixture]
    public class RemoteHostImplTests
    {
        RemoteHost _sut;

        [SetUp]
        public void SetUp()
        {
            _sut = new RemoteHostImpl();
        }

        [Test]
        public void Friends_Should_Count_0_When_Sut_Is_Instantiated()
        {
            _sut.Friends.Count.Should().Be(0);
        }

        [Test]
        public void Friends_Should_Be_Observable()
        {
            _sut.Friends.Should().BeOfType<ObservableCollection<Friend>>();
        }
    }
}
