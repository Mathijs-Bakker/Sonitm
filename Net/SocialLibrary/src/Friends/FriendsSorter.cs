using System.Collections.Generic;
using System.Linq;

namespace Social.Friends
{
    public static class OrderFriends
    {
       static List<Friend> _sortedList;

        public static List<Friend> ByName(this List<Friend> friends)
        {
            return friends.OrderBy(x => x.Name).ToList();
        }
        
        public static List<Friend> ByOnlineStatus(List<Friend> friends)
        {
            return friends.OrderBy(x => x.IsOnline).ToList();
        }
        
        public static List<Friend> ByLastSeen(List<Friend> friends)
        {
            return friends.OrderBy(x => x.LastSeen).ToList();
        }
        
        public static List<Friend> ByLevel(List<Friend> friends)
        {
            return friends.OrderBy(x => x.Level).ToList();
        }
    }
}
