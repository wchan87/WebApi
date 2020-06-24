using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("pet")]
    public class PetController : ControllerBase
    {
        [HttpPost]
        [Route("{petId}/uploadFile")]
        [Consumes("multipart/form-data")]
        // https://docs.microsoft.com/en-us/aspnet/core/web-api/advanced/formatting?view=aspnetcore-3.1
        [Produces("application/json")]
        // TODO fix the issue with [FromForm] annotation
        public ApiResponse UploadFile(long petId, [FromForm] string additionalMetadata, [FromForm] IFormFile file)
        {
            // TODO use Dapper to upload image
            return new ApiResponse();
        }

        [HttpPost]
        [Consumes("application/json", "application/xml")]
        [Produces("application/json", "application/xml")]
        public Pet AddPet([FromBody] Pet body)
        {
            // TODO use Dapper to add Pet
            return body;
        }

        [HttpPut]
        [Consumes("application/json", "application/xml")]
        [Produces("application/json", "application/xml")]
        public Pet UpdatePet([FromBody] Pet body)
        {
            // TODO use Dapper to update Pet
            return body;
        }
    }
}
