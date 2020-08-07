using NUnit.Framework;
using FluentAssertions;

namespace FriendsTests
{
    [TestFixture]
    public class FriendCollection
    {
        [Test]
        public void MyTest()
        {
            var expected = true;

            //Assert.That(expected, Is.False);
            expected.Should().BeFalse();

        }
        
    }
}
