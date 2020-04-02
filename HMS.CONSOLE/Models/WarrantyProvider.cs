using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.CONSOLE.Models
{
     public partial class WarrantyProvider
    {
        public WarrantyProvider()
        {
            MachineWarranties = new HashSet<MachineWarranty>();
        }
        public int WarrantyProviderId { get; set; }
        public string ProviderName { get; set; }
        public int? SupportedExtension { get; set; }
        public string SupportNumber { get; set; }
        public ICollection<MachineWarranty>  MachineWarranties { get; set; }
    }
}
