using System.Collections.Generic;

namespace ComplaintManagement.Core.Services.Responses
{
    public class ComplaintListResponse
    {
        public int TotalCount { get; private set; }
        public List<ComplaintResponse> Data { get; private set; }

        public ComplaintListResponse(int totalCount, List<ComplaintResponse> data)
        {
            TotalCount = totalCount;
            Data = data;
        }
    }
}