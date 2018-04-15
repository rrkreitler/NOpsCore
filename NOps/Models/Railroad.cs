using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NOps.Models
{
    public class Railroad :NOpsEntity
    {
        public decimal Scale { get; set; }
        public bool UseScaleUnits { get; set; }
        public bool UseMetric { get; set; }
        public bool LengthByCount { get; set; }
        public bool WeightByCount { get; set; }
        public string Map { get; set; }
        public int CabooseId { get; set; }
    }
}
