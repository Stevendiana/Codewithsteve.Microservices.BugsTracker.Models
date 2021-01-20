using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codewithsteve.Microservices.BugsTracker.Models
{
    public class BugViewModel
    {
        public string BugId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime ResolveByDate { get; set; }
        public string Name { get; set; }
        public string UserCreated { get; set; }
        public string Status { get; set; }
        public string ProjectId { get; set; }
        public string ClientId { get; set; }

        public string ProjectName { get; set; }
        public string ClientName { get; set; }
        

        public string BugCode { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }
        public string Impact { get; set; }
        public string Severity { get; set; }
        public string severitylevel { get; set; }
        public string Notes { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }
        public string ResolvedBy { get; set; }
        public string SignedoffBy { get; set; }
    }
}
