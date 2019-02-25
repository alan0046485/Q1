using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    public class WaterMeter
    {
        public int MetreID { get; set; }
        public int VolumeUsed { get; set; }
        public bool HasBeenServiced { get; set; }
        public int OwnerAccountID { get; set; }
    }
}
