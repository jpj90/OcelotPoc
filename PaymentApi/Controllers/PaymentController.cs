using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PaymentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
      [HttpGet("GetPayment/{id}")]
      public string Get(int id)
      {
        return $"This is the payment service - passed id = {id}";
      }
      
      [HttpGet("GetPaymentOption/{id}")]
      public string GetPaymentOption(int id)
      {
        return $"We prefer MasterCard - passed id = {id}";
      }
  }
}