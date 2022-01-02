using System.Threading.Tasks;
using ComplaintManagement.Core.Services.Requests;
using ComplaintManagement.Core.Services.Responses;

namespace ComplaintManagement.Core.Services
{
    public interface IComplaintService
    {
        Task<int> CreateComplaintAsync(CreateComplaintRequest request);
        Task<ComplaintListResponse> GetComplaintListAsync(GetComplaintListRequest request);
    }
}