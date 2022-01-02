using System.Collections.Generic;

namespace ComplaintManagement.Core.Services.Responses
{
    public class UserListResponse
    {
        public int TotalCount { get; private set; }
        public List<UserResponse> Data { get; private set; }

        public UserListResponse(int totalCount, List<UserResponse> data)
        {
            TotalCount = totalCount;
            Data = data;
        }
    }
}