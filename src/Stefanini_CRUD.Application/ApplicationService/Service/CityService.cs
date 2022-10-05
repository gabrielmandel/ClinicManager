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
    public class CityService : BaseService<CityService>, ICityService
    {
        private readonly AppDbContext _db;

        public CityService(ILogger<CityService> logger, AppDbContext db) : base(logger)
        {
            _db = db;
        }

        public async Task<GetAllCityResponse> GetAllAsync()
        {
            var entity = await _db.City
                                    .ToListAsync();
            return new GetAllCityResponse()
            {
                CityList = entity != null ? entity.Select(a => (CityDto)a).ToList() : new List<CityDto>()
            };
        }

        public async Task<GetByIdCityResponse> GetByIdAsync(int id)
        {

            var response = new GetByIdCityResponse();

            var entity = await _db.City
                                    .FirstOrDefaultAsync(item => item.Id == id);

            if (entity != null) response.Person = (CityDto)entity;

            return response;
        }

        public async Task<CreateResponse> CreateAsync(CreateCityRequest request)
        {
            if (request == null)
                throw new ArgumentException("Request empty!");

            var city = new City
            {
                Name = request.Name,
                UF = request.UF
            };

            var newCity = Domain.Aggregate.City.Create(city);

            _db.City.Add(newCity);

            await _db.SaveChangesAsync();

            return new CreateResponse() { Id = newCity.Id };
        }

        public async Task<UpdateResponse> UpdateAsync(int id, UpdateCityRequest request)
        {
            if (request == null)
                throw new ArgumentException("Request empty!");

            var entity = await _db.City.FirstOrDefaultAsync(item => item.Id == id);

            if (entity != null)
            {
                var city = new City
                {
                    Name = request.Name ?? entity.Name,
                    UF = request.Name ?? entity.UF,
                };

                entity.Update(city);
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
