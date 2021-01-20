using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Codewithsteve.Microservices.BugsTracker.Models
{
    public class Client: BaseEntity
    {
        [Key]
        public string ClientId { get; set; }
        public string ClientCode { get; set; }
        [Required]
        [StringLength(255)]
        public string Description { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [NotMapped]
        public int TotalBugs
        {
            get
            {
                if (Bugs != null)
                {
                    return Bugs.Count();
                }

                return 0;
            }
            private set { }
        }

        public Client()
        {
            this.ClientId = Guid.NewGuid().ToString();
            this.DateCreated = DateTime.Now;

            Bugs = new Collection<Bug>();
        }

        public ICollection<Bug> Bugs { get; set; }
    }
}
