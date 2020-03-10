using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HKD_WebServer.DataManager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HKD_WebServer.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class RequestMassController : ControllerBase
    {
        RequestMassManager cmm = new RequestMassManager();

        [HttpPost]
        [Route("api/[controller]/GetRequests")]
        public ActionResult GetRequests([FromBody]RequestMassViewModel model)
        {
            var frlt = new FiltratorRequestListMass(model);
            frlt.GetRequestList();

            if (!frlt.model.isExistError)
            {
                return Ok(cmm.GetRequestMassListToJSON(frlt));
            }
            else return BadRequest(frlt.model.msg);
        }

        [HttpGet]
        [Route("api/[controller]/GetModel")]
        public ActionResult GetModel()
        {
            RequestMassViewModel rmvm = new RequestMassViewModel();
            rmvm.IsEmpty();
            return Ok(rmvm);
        }
    }
}