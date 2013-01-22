using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkflowBll.ZFeature.Domain
{
    public class Movie:Feature
    {
        public double WaveID { get; set; }
        public double MovieNumber { get; set; }
        public string MovieName { get; set; }
        public string FileName { get; set; }
    }
}
