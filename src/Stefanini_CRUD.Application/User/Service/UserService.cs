using Stefanini_CRUD.Application.ApplicationService.Models.Dtos;
using Stefanini_CRUD.Application.ApplicationService.Models.Request.User;
using Stefanini_CRUD.Application.ApplicationService.Models.Response;
using Stefanini_CRUD.Application.User.Models;
using Stefanini_CRUD.Infra.Data.Repository;

namespace Stefanini_CRUD.Application.ApplicationService.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }
        public async Task<CreateResponse> InsertAsync(Domain.Aggregate.User request)
        {
            var response = new CreateResponse();

            var newUser = _repository.InsertAsync(request);

            response.Id = newUser.Id;
            
            return response;
        }

        public async Task<GetByIdUserResponse> GetByIdAsync(int id)
        {
            var response = new GetByIdUserResponse();

            var entity = await _repository.GetByIdAsync(id);

            if (entity != null)
            {
                response.Id = entity.Id;
                response.Username = entity.Username;
            }

            return response;
        }

        public Task<UpdateResponse> UpdateAsync(int id, UpdateUserRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<IQueryable<Domain.Aggregate.User>> Get(UserParametersRequest request)
        {
             return _repository.Get(user => user.Username == request.Username);
        }
    } 
}