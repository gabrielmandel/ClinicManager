namespace Stefanini_CRUD.Application.ApplicationService.Models.Request
{
    public class CreatePersonRequest
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string CPF { get; set; }
        public int? Id_City { get; set; }
    }
}
