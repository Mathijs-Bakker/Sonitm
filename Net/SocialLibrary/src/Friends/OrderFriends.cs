using System.Collections.Generic;
using System.Linq;

namespace Social.Friends
{
/// <summary>Class <c>OrderFriends</c> Helper class for sorting a List<Friends>
/// </summary>
/// <example>Sort a friends list by name, online status, level, last seen/logout.
/// <code> OrderFriends.ByOnlineStatus(friends).ByLastSeen(); </code>/// </example>
    public static class OrderFriends
    {
        public static List<Friend> ByName(this List<Friend> friends)
        {
            return friends.OrderBy(x => x.Name).ToList();
        }

        public static List<Friend> ByOnlineStatus(this List<Friend> friends)
        {
            return friends.OrderBy(x => x.IsOnline).ToList();
        }
        
        public static List<Friend> ByLastSeen(this List<Friend> friends)
        {
           return friends.OrderBy(x => x.LastSeen).ToList();
        }
        
        public static List<Friend> ByLevel(this List<Friend> friends)
        {
            return friends.OrderBy(x => x.Level).ToList();
        }
    }
}
