using System.Linq;
using HKD_WebServer.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using HKD_WebServer.DataManager;

namespace HKD_WebServer.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class ContractsController : ControllerBase
    {
        ContractManager cm = new ContractManager();

        [HttpGet]
        [Route("{id}")]
        public ActionResult GetContractInfo(int id)
        {
            return Ok(cm.GetContractInfoToJSON(id));
        }

    }
}