namespace ComplaintManagement.Api.Controllers.Requests
{
    public class CreateUserHttpRequest
    {
        public string Username { get; private set; }

        public CreateUserHttpRequest(string username)
        {
            Username = username;
        }

        public bool IsValid()
        {
            var isValid = !string.IsNullOrEmpty(Username);

            return isValid;
        }
    }
}