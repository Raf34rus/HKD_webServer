using System;
using System.Collections.Generic;

namespace HKD_WebServer.Models
{
    public partial class RequessReson
    {
        public RequessReson()
        {
            FastRequess = new HashSet<FastRequess>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<FastRequess> FastRequess { get; set; }
    }
}
