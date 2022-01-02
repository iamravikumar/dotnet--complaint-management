namespace ComplaintManagement.Core.Services.Responses
{
    public class ComplaintResponse
    {
        public int Id { get; private set; }
        public string Text { get; private set; }
        public ComplaintStatus Status { get; private set; }
        public UserResponse UserResponse { get; private set; }

        public ComplaintResponse(int id, string text, ComplaintStatus status, UserResponse userResponse)
        {
            Id = id;
            Text = text;
            Status = status;
            UserResponse = userResponse;
        }
    }
}