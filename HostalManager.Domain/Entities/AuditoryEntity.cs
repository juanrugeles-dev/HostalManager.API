using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostalManager.Domain.Entities
{
    public abstract class AuditoryEntity
    {
        public Guid  Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime CreatedBy  { get; set; }
        public DateTime UpdatedBy { get; set; }
    }
}
