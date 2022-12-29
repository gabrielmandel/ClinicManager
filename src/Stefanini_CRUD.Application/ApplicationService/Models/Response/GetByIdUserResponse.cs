using Stefanini_CRUD.Application.Common;
using Stefanini_CRUD.Application.ApplicationService.Models.Dtos;

namespace Stefanini_CRUD.Application.ApplicationService.Models.Response
{
    public class GetByIdUserResponse : BaseResponse
    {
        public int Id { get; set; }
        public string Username{ get; set; }

    }
}
