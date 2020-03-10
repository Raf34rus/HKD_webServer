using System;
using System.Linq;
using System.Net;
using HKD_WebServer.Common;
using HKD_WebServer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using HKD_WebServer.DataManager;

namespace HKD_WebServer.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class PartnersController : ControllerBase
    {
        PartnersManager pm = new PartnersManager();

        [HttpGet]
        public ActionResult GetPartners()
        {
            return Ok(pm.GetPartnersListToJSON());
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult GetPartnerInfo(int id)
        {
            return Ok(pm.GetPartnerInfoToJSON(id));
        }

        [HttpPost]
        [Authorize(Roles = Consts.ADAdminRole)]
        public ActionResult CreatePartner([FromBody]Partners _partner)
        {
            try
            {
                using (var ssContext = new ScanStoreContext())
                {
                    if (pm.IsValidInData(_partner))
                    {
                        ssContext.Partners.Add(_partner);
                        ssContext.SaveChanges();
                        return Ok(_partner);
                    }
                    else return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500,ex.Message);
            }
        }

        [HttpPut]
        [Authorize(Roles = Consts.ADAdminRole)]
        [Route("{id}")]
        public ActionResult<string> EditPartner(int id, [FromBody]Partners _partner)
        {
            try
            {
                using (var ssContext = new ScanStoreContext())
                {
                    if (pm.IsValidInData(_partner))
                    {
                        var partner = ssContext.Partners.SingleOrDefault(p => p.Id == id);
                        if (partner != null)
                        {
                            partner.Name = _partner.Name;
                            ssContext.Partners.Update(partner);
                            ssContext.SaveChanges();
                            return Ok(partner);
                        }
                        else  return NotFound();
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