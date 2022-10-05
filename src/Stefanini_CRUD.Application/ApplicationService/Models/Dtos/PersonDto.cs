using Stefanini_CRUD.Domain.Aggregate;

namespace Stefanini_CRUD.Application.ApplicationService.Models.Dtos
{
    public class PersonDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public City City { get; set; }

        public static explicit operator PersonDto(Person p)
        {
            return new PersonDto()
            {
                Id = p.Id,
                Name = p.Name,
                Age = p.Age,
                City = p.City
            };
        }
    }
}
