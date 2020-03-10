using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HKD_WebServer.Controllers
{
    [Authorize]
    //[Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        [Route("api/[controller]/GetUserInfo")]
        public ActionResult GetUserInfo()
        {
            var name = User.Identity.Name.Split('\\')[1];
            DirectorySearcher ds = new DirectorySearcher();
            ds.Filter = "(&(objectClass=user)(objectcategory=person)(name=" + name + "))";
            SearchResult userProperty = ds.FindOne();

            var userEmail = userProperty.Properties["mail"][0];
            var userName = userProperty.Properties["displayname"][0];


            return Ok(userName);
        }
    }
}