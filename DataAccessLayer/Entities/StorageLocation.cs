using System;
using System.Collections.Generic;

namespace DataAccessLayer.Entities
{
    public partial class StorageLocation
    {
        public StorageLocation()
        {
            Handsonn = new HashSet<Handsonn>();
        }

        public int LocationId { get; set; }
        public string LocationName { get; set; }

        public virtual ICollection<Handsonn> Handsonn { get; set; }
    }
}
