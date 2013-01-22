using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WorkflowBll.ZFeature.Domain;
using WorkflowBll.ZFeature.Repository;

namespace WorkflowBll.ZFeature.Service
{
    public class FeatureService
    {
       
        public List<Episode> ListEpisodes(double waveId)
        {
            FeatureRepository<Episode> repository = new EpisodeRepository();
            return repository.ListFeatures (waveId);

        }


        public List<Movie> ListMovies(double waveId)
        {
            FeatureRepository<Movie> repository = new MovieRepository();
            return repository.ListFeatures(waveId);

        }
       
    }
}
