using System;
using System.ComponentModel.DataAnnotations;

namespace SoftwareStore.Domain.Entities
{

    public abstract class EntityBase
    {
        protected EntityBase()
        {
            DateAdded = DateTime.UtcNow;
        }

        [Required]
        public Guid Id { get; set; }

        public virtual Guid AppUserId { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }
    }

}
