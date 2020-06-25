using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("store")]
    public class StoreController : ControllerBase
    {
        [HttpPost("order")]
        public ApiResponse PlaceOrder()
        {
            // TODO use Dapper to place Order
            return new ApiResponse();
        }

        [HttpGet("order/{orderId}")]
        public Order GetOrder(long orderId)
        {
            // TODO use Dapper to get Order
            return null;
        }

        [HttpDelete("order/{orderId}")]
        public Order DeleteOrder(long orderId)
        {
            // TODO use Dapper to delete Order
            return null;
        }

        [HttpGet("inventory")]
        public Dictionary<string, int> GetInventory()
        {
            // TODO use Dapper to get inventory
            return null;
        }
    }
}
