namespace ComplaintManagement.Core.Services.Responses
{
    public class UserResponse
    {
        public int Id { get; private set; }
        public string Username { get; private set; }

        public UserResponse(int id, string username)
        {
            Id = id;
            Username = username;
        }
    }
}