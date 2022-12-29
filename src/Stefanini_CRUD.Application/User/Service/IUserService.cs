using Stefanini_CRUD.Application.ApplicationService.Models.Dtos;
using Stefanini_CRUD.Application.ApplicationService.Models.Request.User;
using Stefanini_CRUD.Application.ApplicationService.Models.Response;
using Stefanini_CRUD.Application.User.Models;
using Stefanini_CRUD.Domain.Aggregate;

namespace Stefanini_CRUD.Application.ApplicationService.Service
{
    public interface IUserService
    {
        Task<IQueryable<Domain.Aggregate.User>> Get(UserParametersRequest request);
        Task<GetByIdUserResponse> GetByIdAsync(int id);
        Task<CreateResponse> InsertAsync(Domain.Aggregate.User request);
        Task<UpdateResponse> UpdateAsync(int id, UpdateUserRequest request);
    }
}
