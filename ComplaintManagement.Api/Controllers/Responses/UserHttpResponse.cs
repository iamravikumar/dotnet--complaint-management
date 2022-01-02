namespace ComplaintManagement.Api.Controllers.Responses
{
    public class UserHttpResponse
    {
        public int Id { get; private set; }
        public string Username { get; private set; }

        public UserHttpResponse(int id, string username)
        {
            Id = id;
            Username = username;
        }
    }
}