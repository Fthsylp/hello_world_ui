using HelloWebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloWebApi.Controllers
{
    [ApiController] // Api tanımlanmaları eklenir
    [Route("home")] // //localhost:7050/home
    public class HomeController : ControllerBase // :ControllerBase özelliklerini homecontrollera ekliyoruz.
    {
        //[HttpGet]
        //public string GetMessage() 
        //{
        //    return "Hello ASP.NET Core Web API";
        //}

        //[HttpGet]
        //public ResponseModel GetMessage() 
        //{
        //    return new ResponseModel
        //    {
        //        HttpStatus = 200,
        //        Message = "Hello ASP.NET Core Web API"
        //    };

        //}

        [HttpGet]
        public IActionResult GetMessage()
        {
            var result =  new ResponseModel
            {
                HttpStatus = 200,
                Message = "Hello ASP.NET Core Web API"
            };

            return Ok(result);
        }
    }
}
