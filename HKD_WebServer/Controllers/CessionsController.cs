using System;
using System.Linq;
using HKD_WebServer.Common;
using HKD_WebServer.DataManager;
using HKD_WebServer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HKD_WebServer.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class CessionsController : ControllerBase
    {
        CessionsManager cm = new CessionsManager();

        [HttpGet]
        public ActionResult GetCessions()
        {
            return Ok(cm.GetCessionsListToJSON());
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult GetCessionInfo(int id)
        {
            return Ok(cm.GetCessionInfoToJSON(id));
        }

        [HttpPost]
        //[Authorize(Roles = Consts.ADAdminRole)]
        public ActionResult CreateCessions([FromBody]Cessions _cession)
        {
            try
            {
                if (cm.IsValidInData(_cession))
                {
                    using (var ssContext = new ScanStoreContext())
                    {
                        ssContext.Cessions.Add(_cession);
                        ssContext.SaveChanges();
                    }
                    return Ok(_cession);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut]
        //[Authorize(Roles = Consts.ADAdminRole)]
        [Route("{id}")]
        public ActionResult EditCession(int id, [FromBody]Cessions _cession)
        {
            try
            {
                using (var ssContext = new ScanStoreContext())
                {
                    if (cm.IsValidInData(_cession))
                    {
                        var cession = ssContext.Cessions.SingleOrDefault(c => c.Id == id);
                        if (cession != null)
                        {
                            cession.Name = _cession.Name;
                            cession.PartnerId = _cession.PartnerId;
                            cession.Date = _cession.Date;
                            cession.CommitDate = _cession.CommitDate;
                            ssContext.Cessions.Update(cession);
                            ssContext.SaveChanges();
                            return Ok(cession);
                        }
                        else return NotFound();
                    }
                    else return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

    }
}