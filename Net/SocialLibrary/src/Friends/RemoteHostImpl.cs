using System.Collections.ObjectModel;

namespace Social.Friends
{
    public class RemoteHostImpl : RemoteHost
    {
        public ObservableCollection<Friend> Friends { get; private set; }

        public RemoteHostImpl()
        {
            Friends = new ObservableCollection<Friend>();
        }
    }
}

