using System;
using System.Collections.Generic;

namespace DataAccessLayer.Entities
{
    public partial class Handsonn
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? DateTime { get; set; }
        public int? LocationId { get; set; }

        public virtual StorageLocation Location { get; set; }
    }
}
