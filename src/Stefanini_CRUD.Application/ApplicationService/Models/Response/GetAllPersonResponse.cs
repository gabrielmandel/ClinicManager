using Stefanini_CRUD.Application.Common;
using Stefanini_CRUD.Application.ApplicationService.Models.Dtos;

namespace Stefanini_CRUD.Application.ApplicationService.Models.Response
{
    public class GetAllPersonResponse: BaseResponse
    {
        public List<PersonDto> PersonList { get; set; }
    }
}
