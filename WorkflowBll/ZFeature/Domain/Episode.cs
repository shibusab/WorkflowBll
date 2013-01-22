using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkflowBll.ZFeature.Domain
{
    public class Episode:Feature 
    {
        public double WaveID { get; set; }
        public double SeriesID { get; set; }
        public double SeasonID { get; set; }
        public double EpisodeNumber {get;set;}
        public string EpisodeName {get;set;}
        public string FileName { get; set; }
    }
}
