using System.Net;

namespace HKD_WebServer.Common
{
    public static class HkdJsonConvert 
    {
        public static string SerializeObject(object value)
        {
            if (value == null)
            {
                return HttpStatusCode.NotFound.ToString();
            }
            else
            {
                return Newtonsoft.Json.JsonConvert.SerializeObject(value);
            }
        }
    }
}
