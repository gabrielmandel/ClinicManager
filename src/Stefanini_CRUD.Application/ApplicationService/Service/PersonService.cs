using Stefanini_CRUD.Application.Common;
using Stefanini_CRUD.Application.ApplicationService.Models.Dtos;
using Stefanini_CRUD.Application.ApplicationService.Models.Request;
using Stefanini_CRUD.Application.ApplicationService.Models.Response;
using Stefanini_CRUD.Infra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Stefanini_CRUD.Domain.Aggregate;

namespace Stefanini_CRUD.Application.ApplicationService.Service
{
    public class PersonService : BaseService<PersonService>, IPersonService
    {
        private readonly AppDbContext _db;

        public PersonService(ILogger<PersonService> logger, AppDbContext db) : base(logger)
        {
            _db = db;
        }

        public async Task<GetAllPersonResponse> GetAllAsync()
        {
            var entity = await _db.Person
                                    .Include(p => p.City)
                                    .ToListAsync();
            return new GetAllPersonResponse()
            {
                PersonList = entity != null ? entity.Select(a => (PersonDto)a).ToList() : new List<PersonDto>()
            };
        }

        public async Task<GetByIdPersonResponse> GetByIdAsync(int id)
        {

            var response = new GetByIdPersonResponse();

            var entity = await _db.Person
                                    .Include(p => p.City)
                                    .FirstOrDefaultAsync(item => item.Id == id);

            if (entity != null) response.Person = (PersonDto)entity;

            return response;
        }

        public async Task<CreateResponse> CreateAsync(CreatePersonRequest request)
        {
            if (request == null)
                throw new ArgumentException("Request empty!");

            var person = new Person
            {
                Name = request.Name,
                Age = request.Age,
                CPF = request.CPF,
                Id_City = request.Id_City
            };

            var newPerson = Domain.Aggregate.Person.Create(person);

            _db.Person.Add(newPerson);

            await _db.SaveChangesAsync();

            return new CreateResponse() { Id = newPerson.Id };
        }

        public async Task<UpdateResponse> UpdateAsync(int id, UpdatePersonRequest request)
        {
            if (request == null)
                throw new ArgumentException("Request empty!");

            var entity = await _db.Person.FirstOrDefaultAsync(item => item.Id == id);

            if (entity != null)
            {
                var person = new Person
                {
                    Name = request.Name ?? entity.Name,
                    Age = request.Age ?? entity.Age,
                    CPF = request.CPF ?? entity.CPF,
                    Id_City = request.Id_City?? entity.Id_City
                };

                entity.Update(person);
                await _db.SaveChangesAsync();
            }

            return new UpdateResponse();
        }

        public async Task<DeleteResponse> DeleteAsync(int id)
        {

            var entity = await _db.Person.FirstOrDefaultAsync(item => item.Id == id);

            if (entity != null)
            {
                _db.Remove(entity);
                await _db.SaveChangesAsync();
            }

            return new DeleteResponse();
        }
    }
}
