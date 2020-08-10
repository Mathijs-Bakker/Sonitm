using System;

namespace Social.Friends
{
    public struct Friend
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public bool IsOnline { get; private set; }
        public DateTime LastSeen { get; private set; }
        public int Level { get; private set; }

        public Friend (
                int id, 
                string name,
                bool isOnline,
                DateTime lastSeen,
                int level)
        {
            Id = id;
            Name = name;
            IsOnline = isOnline;
            LastSeen = lastSeen;
            Level = level;
        }
    }
}
