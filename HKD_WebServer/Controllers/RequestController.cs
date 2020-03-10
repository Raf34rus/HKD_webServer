using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HKD_WebServer.DataManager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HKD_WebServer.Controllers
{
    [Authorize]
    //[Route("api/[controller]")]
    [ApiController]
    public class RequestController : ControllerBase
    {
        RequestManager rm = new RequestManager();

        [HttpGet]
        //[Route("{id}")]
        [Route("api/[controller]/GetRequestInfo/{id}")]
        public ActionResult GetRequestInfo(int id)
        {
            return Ok(rm.GetRequestInfoToJSON(id));
        }

    }
}