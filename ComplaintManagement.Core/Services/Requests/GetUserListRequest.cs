namespace ComplaintManagement.Core.Services.Requests
{
    public class GetUserListRequest
    {
        public string Username { get; private set; }
        public int PageSize { get; private set; }
        public int PageNumber { get; private set; }

        public GetUserListRequest(int pageSize, int pageNumber, string username = null)
        {
            Username = username;
            PageSize = pageSize;
            PageNumber = pageNumber;
        }
    }
}