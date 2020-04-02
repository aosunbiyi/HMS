using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.CONSOLE.Models
{
     public partial class MachineType
    {
        public MachineType()
        {
            Machines = new HashSet<Machine>();
        }
        public int MachineTypeId { get; set; }
        public string Description { get; set; }
        public ICollection<Machine>  Machines { get; set; }

    }
}
