using System.Threading.Tasks;
using ComplaintManagement.Core.Services.Requests;
using ComplaintManagement.Core.Services.Responses;

namespace ComplaintManagement.Core.Services
{
    public interface IUserService
    {
        Task<int> CreateUserAsync(CreateUserRequest request);
        Task<UserListResponse> GetUserListAsync(GetUserListRequest request);
    }
}