using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiSgsElavon.Entities;
using WebApiSgsElavon.Services;

namespace WebApiSgsElavon.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            this._userService = userService;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public async Task<ActionResult> Authenticate([FromBody]User userParam)
        {
             var user = await _userService.Authenticate(userParam.UserName, userParam.Password);

            if(user == null)
            {
                return BadRequest(new { message = "Usuario o contraseña son incorrectos" });
            }

            return Ok(user);
        }

        [Authorize(Roles = Role.Admin)]
        [HttpGet]
        public ActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var user = _userService.GetById(id);

            if(user == null)
            {
                return NotFound();
            }

            var currentUserId = int.Parse(User.Identity.Name);
            if(id != currentUserId && !User.IsInRole(Role.Admin))
            {
                return Forbid();
            }

            return Ok(user);
        }
    }
}