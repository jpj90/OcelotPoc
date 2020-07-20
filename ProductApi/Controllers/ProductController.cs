using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProductApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
      [HttpGet("GetProducts/{id}")]
      public string Get(int id)
      {
        return $"This is the product service - passed id = {id}";
      }

      [HttpGet("GetProductOfTheWeek/{id}")]
      public string GetProductOfTheWeek(int id)
      {
        return $"Product of the week is tofu - passed id = {id}";
      }
    }
}