using Stefanini_CRUD.Application.ApplicationService.Models.Request;
using Stefanini_CRUD.Application.ApplicationService.Models.Response;
using System.Threading.Tasks;

namespace Stefanini_CRUD.Application.ApplicationService.Service
{
    public interface IPersonService
    {
        Task<GetAllPersonResponse> GetAllAsync();
        Task<GetByIdPersonResponse> GetByIdAsync(int id);
        Task<CreateResponse> CreateAsync(CreatePersonRequest request);
        Task<UpdateResponse> UpdateAsync(int id, UpdatePersonRequest request);
        Task<DeleteResponse> DeleteAsync(int id);
    }
}
