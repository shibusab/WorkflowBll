using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WorkflowBll.ZFeature.Domain;

namespace WorkflowBll.ZFeature.Repository
{
    public class MovieRepository:FeatureRepository<Movie>
    {
         private  List<Movie> features = new List<Movie>();

       public  MovieRepository()
       {
           FillData();
       }

       private void FillData()
       {
           features.Add(new Movie
           {
               LineID = 4,
               WaveID = 1,
               MovieNumber=200,
               FileName = "File_For_Movie_200"
           });

           features.Add(new Movie
           {
               LineID = 5,
               WaveID = 1,
               MovieNumber = 201,
               FileName = "File_For_Movie_201"
           });

           features.Add(new Movie
           {
               LineID = 6,
               WaveID = 1,
               MovieNumber = 202,
              FileName = "File_For_Movie_202"

          });
       }
        public override Movie ListFeature(double lineId)
        {
            return features.Find(p => p.LineID == lineId);
        }

        public override List<Movie> ListFeatures(double waveId)
        {
            return features;
        }
    }
}
