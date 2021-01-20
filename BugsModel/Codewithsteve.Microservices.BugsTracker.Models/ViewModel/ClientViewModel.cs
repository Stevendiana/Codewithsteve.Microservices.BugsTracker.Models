using Codewithsteve.Microservices.BugsTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codewithsteve.Microservices.BugsTracker.Models
{
    public class ClientViewModel: BaseEntity
    {
        public string ClientId { get; set; }
        public string ClientCode { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public int TotalBugs { get; set; }

    }
}
