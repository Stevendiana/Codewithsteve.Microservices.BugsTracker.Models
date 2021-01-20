using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codewithsteve.Microservices.BugsTracker.Models
{
    public class BaseEntity
    {
        public DateTime? DateCreated { get; set; }
        public string UserCreatedId { get; set; }
        public string UserCreatedEmail { get; set; }
        public string UserCreatedFullName { get; set; }

       

        public DateTime? DateModified { get; set; }
        public string UserModifiedId { get; set; }
        public string UserModifiedEmail { get; set; }
        public string UserModifiedFullName { get; set; }



    }
}
