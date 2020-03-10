using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using HKD_WebServer.DataManager;
using HKD_WebServer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.Core;
using Microsoft.AspNetCore.Identity;

namespace HKD_WebServer.Controllers
{
    [ApiController]
    //[Authorize]
    public class CessionScansController : ControllerBase
    {
        [HttpDelete]
        //[Authorize(Policy = Consts.ADAdminRole) ]
        [Route("api/[controller]/DelScan/{id}")]
        public ActionResult DelScan(int id)
        {
            ScanStoreContext ssContext = new ScanStoreContext();
            var file = ssContext.CessionScans.SingleOrDefault(cs => cs.Id == id);
            if (file != null)
            {
                ssContext.CessionScans.Remove(file);
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
        public ActionResult GetScan(int id)
        {
            //var User = HttpContext.User.Identity.Name.ToString();
            ScanStoreContext ssContext = new ScanStoreContext();
            var file = ssContext.CessionScans.SingleOrDefault(cs => cs.Id == id);
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

        //привязать пути к веб-конфигу:
        [HttpGet]
        [Route("api/[controller]/GetZip/{id}")]
        public ActionResult GetZip(int id)
        {
            ScanStoreContext ssContext = new ScanStoreContext();
            var scans = ssContext.CessionScans.Where(c=>c.CessionId == id).ToList();

            var FileName = string.Format("Сканы цессии {0} от {1:dd.MM.yyyy}.zip", scans.First().Cession.Name, scans.First().Cession.Date);
            ZipFile zip_file = new ZipFile(FileName);
            
            if (scans.Count() != 0)
            {
                foreach (var itemScan in scans)
                {
                    if (System.IO.File.Exists(itemScan.Path))
                    {
                        zip_file.Add(itemScan.Path);
                    }
                }
            }
            zip_file.AddDirectory("");
            zip_file.Close();
            return PhysicalFile("","");

        }

    }
}