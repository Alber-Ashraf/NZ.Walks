using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZ.Walks.Domain.Entities
{
    public class Walk
    {
        private Guid Id { get; set; }
        private string Name { get; set; }
        private string Description { get; set; }
        private double LengthInKm { get; set; }
        public string? WalkImageUrl { get; set; }

        // Foreign keys
        private Guid DifficultyId { get; set; }
        private Guid RegionId { get; set; }

        // Navigation properties
        public Difficulty Difficulty { get; set; }
        public Region Region { get; set; }
    }
}
