using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using HKD_WebServer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HKD_WebServer.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class ContractScansController : ControllerBase
    {
        public class CessionScansController : ControllerBase
        {
            [HttpDelete]
            [Authorize(Policy = Consts.ADAdminRole) ]
            [Route("api/[controller]/DelDoc/{id}")]
            public ActionResult DelDoc(Guid id)
            {
                ScanStoreContext ssContext = new ScanStoreContext();
                var file = ssContext.ContractScans.SingleOrDefault(cs => cs.Id == id);
                if (file != null)
                {
                    ssContext.ContractScans.Remove(file);
                    ssContext.SaveChanges();
                    return Ok();
                }
                else
                {
                    return NotFound();
                }
            }

            [HttpDelete]
            [Authorize(Policy = Consts.ADAdminRole) ]
            [Route("api/[controller]/DelScan/{id}")]
            public ActionResult DelScan(Guid id)
            {
                ScanStoreContext ssContext = new ScanStoreContext();
                var file = ssContext.ContractScans.SingleOrDefault(cs => cs.Id == id);
                if (file != null)
                {
                    file.FileName = "";
                    file.InsertDate = null;
                    file.Path = "";
                    file.Type = "";
                    file.Size = null;
                    file.HashFile = null;
                    ssContext.ContractScans.Update(file);
                    ssContext.SaveChanges();
                    return Ok();
                }
                else
                {
                    return NotFound();
                }
            }

            [HttpGet]
            [Route("api/[controller]/GetScan/{id}")]
            public ActionResult GetScan(Guid id)
            {
                //var User = HttpContext.User.Identity.Name.ToString();
                ScanStoreContext ssContext = new ScanStoreContext();
                var file = ssContext.ContractScans.SingleOrDefault(cs => cs.Id == id);
                if (file != null)
                {
                    string file_path = file.Path;
                    string file_type = file.Type;
                    string file_name = Path.GetFileName(file.Path);
                    return PhysicalFile(file_path, file_type, file_name);
                }
                else
                {
                    return NotFound();
                }
            }
        }
    }
}