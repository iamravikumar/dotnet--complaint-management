using System.Collections.Generic;

namespace ComplaintManagement.Api.Controllers.Responses
{
    public class UserListHttpResponse
    {
        public int TotalCount { get; private set; }
        public List<UserHttpResponse> Data { get; private set; }

        public UserListHttpResponse(int totalCount, List<UserHttpResponse> data)
        {
            TotalCount = totalCount;
            Data = data;
        }
    }
}