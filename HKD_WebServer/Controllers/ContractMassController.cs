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
    public class ContractMassController : ControllerBase
    {
        ContractMassManager cmm = new ContractMassManager();

        [HttpPost]
        [Route("api/[controller]/GetContracts")]
        public ActionResult GetContracts([FromBody]ContractsMassViewModel model)
        {
            var flt = new FiltratorContractListMass(model);
            flt.GetContractList();

            if (!flt.model.isExistError)
            {
                return Ok(cmm.GetContractMassListToJSON(flt));
            }
            else return BadRequest(flt.model.msg);
        }

        [HttpGet]
        [Route("api/[controller]/GetModel")]
        public ActionResult GetModel()
        {
            ContractsMassViewModel cmvm = new ContractsMassViewModel();
            cmvm.IsEmpty();
            return Ok(cmvm);
        }

    }
}