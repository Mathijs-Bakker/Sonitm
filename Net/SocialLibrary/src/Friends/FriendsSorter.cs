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
    }
}
