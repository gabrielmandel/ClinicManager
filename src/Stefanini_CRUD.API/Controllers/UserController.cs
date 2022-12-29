using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Stefanini_CRUD.Application.ApplicationService.Service;

namespace Stefanini_CRUD.API.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IUserService _userService;

        public UserController(IConfiguration configuration, IUserService userService)
        {
            _configuration = configuration;
            _userService = userService;
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            try
            {
                var action = await _userService.GetByIdAsync(id);
                return Ok(action);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}