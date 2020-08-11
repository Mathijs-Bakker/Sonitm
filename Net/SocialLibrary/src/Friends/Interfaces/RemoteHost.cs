using Social.Friends; 
using System.Collections.ObjectModel;
using  System.Collections.Specialized;

public interface RemoteHost
{
    ObservableCollection<Friend> Friends { get; }
    void FriendsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e);
}
