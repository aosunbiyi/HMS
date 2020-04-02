using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.CONSOLE.Models
{
     public partial class OperatingSys
    {
        public OperatingSys()
        {
            Machines = new HashSet<Machine>();
        }

        public int OperatingSysId { get; set; }
        public string Name { get; set; }

        public bool StillSupported { get; set; }
        public ICollection<Machine> Machines { get; set; }
    }
}
