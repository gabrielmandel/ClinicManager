using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stefanini_CRUD.Application.ApplicationService.Models.Request.User
{
    public class UpdateUserRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}