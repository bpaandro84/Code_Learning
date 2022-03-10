using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace Coding_Test.Controllers
{
    [Route("backend/question/[controller]")]
    [ApiController]
    public class OneController : ControllerBase
    {
        List<One> lisOne = new List<One>
        {
            new One{id=124925, category=8, title="Generic Granite Soap", description="Boston's most advanced compression " +
                    " wear technology increases muscle oxygenation, stabilizes active " +
                    "muscles" ,footer= "Small", tags = new string[]{ "Music", "Sports", "Grocery", "Computers", "Sports"},createdAt = DateTime.Now.ToString("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss.fffffffK")},
        };

        //[HttpGet]
        //public async Task<IActionResult> Index()
        //{
        //    List<One> oneList = new List<One>();
        //    using (var httpClient = new HttpClient())
        //    {
        //        using (var response = await httpClient.GetAsync("https://screening.moduit.id/backend/question/one"))
        //        {
        //            string apiResponse = await response.Content.ReadAsStringAsync();
        //            oneList = JsonConvert.DeserializeObject<List<One>>(apiResponse);
        //        }
        //    }
        //    return (IActionResult)oneList;
        //}

        [HttpGet]
        public  IEnumerable<One> Get() 
        {
            

            return lisOne;
        }
    }
}
