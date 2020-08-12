using System.Collections.Generic;
using System.Linq;

namespace Social.Friends
{
    public class FriendsSorter
    {
        List<Friend> _sortedList;

        public List<Friend> SortByName(List<Friend> friends)
        {
            _sortedList = friends.OrderBy(x => x.Name).ToList();
            return _sortedList;
        }
        
        public List<Friend> SortByOnlineStatus(List<Friend> friends)
        {
            _sortedList = friends.OrderBy(x => x.IsOnline).ToList();
            return _sortedList;
        }
        
        public List<Friend> SortByLastSeen(List<Friend> friends)
        {
            _sortedList = friends.OrderBy(x => x.LastSeen).ToList();
            return _sortedList;
        }
        
        public List<Friend> SortByLevel(List<Friend> friends)
        {
            _sortedList = friends.OrderBy(x => x.Level).ToList();
            return _sortedList;
        }
    }
}
