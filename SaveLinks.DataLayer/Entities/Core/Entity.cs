using System;
using System.ComponentModel.DataAnnotations;

namespace SaveLinks.DataLayer.Entities.Core
{
    public class Entity
    {
        [Key]
        public int Id { get; set; }

        //Audit
        public DateTime CreatedOn { get; set; }
        public virtual ApplicationUser CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public virtual ApplicationUser UpdatedBy { get; set; }
    }
}