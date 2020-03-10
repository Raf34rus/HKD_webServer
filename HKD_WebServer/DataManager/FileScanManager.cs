using HKD_WebServer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HKD_WebServer.DataManager
{
    public class FileScanManager
    {
        public void GetPathToReport()
        {
            //string pathFile = Program.cfgGlobal.GetDnsPathtoUse(4) + @"massUploads\" + DateTime.Now.ToString("yyyyMMdd") + "\\"; //+ " \\report_" + _task.id.ToString() + ".csv";
            //if (!Directory.Exists(pathFile))
            //    Directory.CreateDirectory(pathFile);
            //var fileId = 0;
            //while (System.IO.File.Exists(pathFile + @"report_" + this.id.ToString() + "_" + fileId + @".csv")) fileId++;
            //this.pathOutFile = pathFile + @"report_" + this.id.ToString() + "_" + fileId + @".csv";
        }

        public static string MassUpload()
        {
            ScanStoreContext ssContext = new ScanStoreContext();
            var sdir = ssContext.ConfigWebServer.SingleOrDefault(cws => cws.Key == "StorePath").Value;
            return sdir + @"massUploads\";
        }
        public static string MassUpload(DateTime date)
        {
            return MassUpload() + date.ToString("yyyyMMdd") + "\\";
        }

    }
}
