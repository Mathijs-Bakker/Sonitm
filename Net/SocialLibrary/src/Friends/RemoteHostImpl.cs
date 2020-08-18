using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Social.Friends
{
    public class RemoteHostImpl : RemoteHost
    {
        public ObservableCollection<Friend> Friends { get; private set; }

        public RemoteHostImpl()
        {
            Friends = new ObservableCollection<Friend>();
            //Friends.CollectionChanged += FriendsCollectionChanged;
        }

        public void FriendsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e){}
    }
}

