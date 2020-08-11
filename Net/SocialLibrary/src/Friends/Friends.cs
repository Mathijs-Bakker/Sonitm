using System.Collections.Generic;

namespace Social.Friends
{
    public class Friends
    {
        public IList<Friend> List { get; private set; }
        RemoteHost _remoteHost;

        public Friends(RemoteHost remoteHost)
        {
            List = new List<Friend>();            
            _remoteHost = remoteHost;
        }

        public void Update()
        {
            List = _remoteHost.Friends;
        }
    }
}
