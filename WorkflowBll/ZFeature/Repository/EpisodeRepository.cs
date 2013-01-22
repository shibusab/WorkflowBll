using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WorkflowBll.ZFeature.Domain;

namespace WorkflowBll.ZFeature.Repository
{
    public class EpisodeRepository: FeatureRepository<Episode> 
    {
       private  List<Episode> features = new List<Episode>();

       public  EpisodeRepository()
       {
           FillData();
       }

       private void FillData()
       {
           features.Add(new Episode
           {
               LineID = 1,
               WaveID = 1,
               SeriesID = 1,
               SeasonID = 1,
               EpisodeNumber = 100,
               EpisodeName = "Episode 100",
               FileName = "File_For_Episode_100"
           });

           features.Add(new Episode
           {
               LineID = 2,
               WaveID = 1,
               SeriesID = 1,
               SeasonID = 1,
               EpisodeNumber = 101,
               EpisodeName = "Episode 101",
               FileName = "File_For_Episode_101"
           });

           features.Add(new Episode
           {
               LineID = 3,
               WaveID = 1,
               SeriesID = 1,
               SeasonID = 1,
               EpisodeNumber = 103,
               EpisodeName = "Episode 103",
               FileName = "File_For_Episode_103"

           });
       }

        public override List<Episode> ListFeatures(double waveId)
        {
            return features;
        }

        public override Episode ListFeature(double lineId)
        {
            return features.Find(p=>p.LineID==lineId);
        }
    }
}
