using Social.Friends; 
using System.Collections.ObjectModel;

public interface RemoteHost
{
    ObservableCollection<Friend> Friends { get; }
}
