using Stefanini_CRUD.Application.Common;
using Stefanini_CRUD.Application.ApplicationService.Models.Dtos;

namespace Stefanini_CRUD.Application.ApplicationService.Models.Response
{
    public class GetByIdCityResponse : BaseResponse
    {
        public CityDto Person { get; set; }
    }
}
