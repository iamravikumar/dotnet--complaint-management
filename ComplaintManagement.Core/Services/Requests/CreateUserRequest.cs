namespace ComplaintManagement.Core.Services.Requests
{
    public class CreateUserRequest
    {
        public string Username { get; private set; }

        public CreateUserRequest(string username)
        {
            Username = username;
        }
    }
}