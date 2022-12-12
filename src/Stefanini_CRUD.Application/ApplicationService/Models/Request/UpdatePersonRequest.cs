namespace Stefanini_CRUD.Application.ApplicationService.Models.Response
{
    public class UpdatePersonRequest
    {
        public string Name { get; set; }
        public int? Age { get; set; }
        public string CPF { get; set; }
        public int? Id_City { get; set; }
    }
}
