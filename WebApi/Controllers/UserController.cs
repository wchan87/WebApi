using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("user")]
    public class UserController : ControllerBase
    {
        [HttpPost("createWithArray")]
        [Consumes("application/json", "application/xml")]
        public ApiResponse CreateUsersWithArray([FromBody] IEnumerable<User> body)
        {
            // TODO use Dapper to add Users
            return new ApiResponse();
        }

        [HttpPost("createWithList")]
        [Consumes("application/json", "application/xml")]
        public ApiResponse CreateUsersWithList([FromBody] IEnumerable<User> body)
        {
            // TODO use Dapper to add Users
            return new ApiResponse();
        }

        [HttpGet("{username}")]
        [Produces("application/json", "application/xml")]
        public User GetUser(string username)
        {
            // TODO use Dapper to get User
            return null;
        }

        [HttpPut("{username}")]
        [Consumes("application/json", "application/xml")]
        [Produces("application/json", "application/xml")]
        public User UpdateUser(string username, [FromBody] User body)
        {
            // TODO use Dapper to update User
            return null;
        }

        [HttpDelete("{username}")]
        [Produces("application/json", "application/xml")]
        public User DeleteUser(string username)
        {
            // TODO use Dapper to delete User
            return null;
        }

        [HttpGet("login")]
        [Produces("application/json", "application/xml")]
        public ApiResponse Login(string username, string password)
        {
            // TODO use Dapper to check login and set headers for session
            return new ApiResponse();
        }

        [HttpGet("logout")]
        [Produces("application/json", "application/xml")]
        public ApiResponse Logout()
        {
            // TODO use Dapper to check login and reset headers
            return new ApiResponse();
        }

        [HttpPost]
        [Consumes("application/json", "application/xml")]
        [Produces("application/json", "application/xml")]
        public ApiResponse CreateUser([FromBody] User body)
        {
            // TODO use Dapper to create user
            return new ApiResponse();
        }
    }
}
