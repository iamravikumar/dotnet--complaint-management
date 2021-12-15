using System;

namespace ComplaintManagement.Core
{
    public class User
    {
        public int Id { get; private set; }
        public string Username { get; private set; }
        public DateTime CreatedOn { get; private set; }

        public User(string username)
        {
            Username = username;
            CreatedOn = DateTime.UtcNow;
        }
    }
}