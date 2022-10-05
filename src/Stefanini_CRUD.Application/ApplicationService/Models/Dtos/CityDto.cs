using Stefanini_CRUD.Domain.Aggregate;

namespace Stefanini_CRUD.Application.ApplicationService.Models.Dtos
{
    public class CityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UF { get; set; }

        public static explicit operator CityDto(City c)
        {
            return new CityDto()
            {
                Id = c.Id,
                Name = c.Name,
                UF = c.UF
            };
        }
    }
}
