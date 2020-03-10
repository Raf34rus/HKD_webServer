using System;
using System.Collections.Generic;

namespace HKD_WebServer.Models
{
    public partial class ServiceTasksStatusesTask
    {
        public ServiceTasksStatusesTask()
        {
            ServiceTasks = new HashSet<ServiceTasks>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<ServiceTasks> ServiceTasks { get; set; }
    }
}
