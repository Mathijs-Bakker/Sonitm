namespace Social.Friends
{
    public struct Friend
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Friend (int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
