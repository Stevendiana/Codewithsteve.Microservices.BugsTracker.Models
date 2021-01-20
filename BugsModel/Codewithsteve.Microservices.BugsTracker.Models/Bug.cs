using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Codewithsteve.Microservices.BugsTracker.Models
{
    
    public class Bug: BaseEntity
    {
        [Key]
        public string BugId { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public string Status { get; set; }
        [Required]
        public string ClientId { get; set; }
        public Client Client { get; set; }

        public string ProjectName { get; set; }
        public DateTime ResolveByDate { get; set; }
        public string ClientName { get; set; }

        public string BugCode { get; set; }
        [Required]
        [StringLength(255)]
        public string Description { get; set; }
        [Required]
        public string Priority { get; set; }
        [Required]
        public string Impact { get; set; }
        public int Severity { get; set; }

        public string severitylevel { get; set; }
        
        public string Notes { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }
        public string ResolvedBy { get; set; }
        public string SignedoffBy { get; set; }

       

        public Bug()
        {
           
            this.DateCreated = DateTime.Now;
 
        }
    }
}
