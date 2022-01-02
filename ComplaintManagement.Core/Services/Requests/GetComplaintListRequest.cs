namespace ComplaintManagement.Core.Services.Requests
{
    public class GetComplaintListRequest
    {
        public int? UserId { get; private set; }
        public ComplaintStatus? Status { get; private set; }
        public int PageNumber { get; private set; }
        public int PageSize { get; private set; }

        public GetComplaintListRequest(int pageNumber, int pageSize, int? userId = null, ComplaintStatus? status = null)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
            UserId = userId;
            Status = status;
        }
    }
}