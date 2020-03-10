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
    public class ReferencesController : ControllerBase
    {
        ReferencesManager rm = new ReferencesManager();

        [HttpGet]
        [Route("api/[controller]/GetContractRequestTypes/")]
        public ActionResult GetContractRequestTypes()
        {
            return Ok(rm.GetContractRequestTypesToJSON());
        }

        [HttpGet]
        [Route("api/[controller]/GetContractRequestTypesStatusVisible/")]
        public ActionResult GetContractRequestTypesStatusVisible()
        {
            return Ok(rm.GetContractRequestTypesStatusVisibleToJSON());
        }

        [HttpGet]
        [Route("api/[controller]/GetContractScanExists/")]
        public ActionResult GetContractScanExists()
        {
            return Ok(rm.GetContractScanExistsToJSON());
        }

        [HttpGet]
        [Route("api/[controller]/GetContractRequestStatuses/")]
        public ActionResult GetContractRequestStatuses()
        {
            return Ok(rm.GetContractRequestStatusesToJSON());
        }

        [HttpGet]
        [Route("api/[controller]/GetContractSigns/")]
        public ActionResult GetContractSigns()
        {
            return Ok(rm.GetContractSignsToJSON());
        }

        [HttpGet]
        [Route("api/[controller]/GetOfficeCity/")]
        public ActionResult GetOfficeCity()
        {
            return Ok(rm.GetOfficeCityToJSON());
        }

        [HttpGet]
        [Route("api/[controller]/GetOfficeAddress/")]
        public ActionResult GetOfficeAddress()
        {
            return Ok(rm.GetOfficeAddressToJSON());
        }

        [HttpGet]
        [Route("api/[controller]/GetServiceTasksTypesTask/")]
        public ActionResult GetServiceTasksTypesTask()
        {
            return Ok(rm.GetServiceTasksTypesTaskToJSON());
        }

        [HttpGet]
        [Route("api/[controller]/GetServiceTasksStatusesTask/")]
        public ActionResult GetServiceTasksStatusesTask()
        {
            return Ok(rm.GetServiceTasksStatusesTaskToJSON());
        }
    }
}