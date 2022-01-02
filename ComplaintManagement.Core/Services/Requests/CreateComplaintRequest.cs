namespace ComplaintManagement.Core.Services.Requests
{
    public class CreateComplaintRequest
    {
        public int UserId { get; private set; }
        public string Text { get; private set; }

        public CreateComplaintRequest(int userId, string text)
        {
            UserId = userId;
            Text = text;
        }
    }
}