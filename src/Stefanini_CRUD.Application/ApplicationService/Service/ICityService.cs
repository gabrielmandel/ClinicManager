using Stefanini_CRUD.Application.ApplicationService.Models.Request;
using Stefanini_CRUD.Application.ApplicationService.Models.Response;
using System.Threading.Tasks;

namespace Stefanini_CRUD.Application.ApplicationService.Service
{
    public interface ICityService
    {
        Task<GetAllCityResponse> GetAllAsync();
        Task<GetByIdCityResponse> GetByIdAsync(int id);
        Task<CreateResponse> CreateAsync(CreateCityRequest request);
        Task<UpdateResponse> UpdateAsync(int id, UpdateCityRequest request);
        Task<DeleteResponse> DeleteAsync(int id);
    }
}
