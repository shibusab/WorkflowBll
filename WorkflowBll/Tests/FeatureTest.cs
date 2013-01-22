using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using WorkflowBll.ZFeature.Service;

namespace WorkflowBll.Tests
{
    [TestFixture]
    public class FeatureTest
    {
        [Test]
        public void TestListEpisodes()
        {
            FeatureService service = new FeatureService();
            double waveId = 1;
            var results=service.ListEpisodes(waveId);
            var expectedResult = results.Exists(p => p.EpisodeNumber == 100);
            Assert.That(expectedResult, "List Episode doesn't return any values");
        }


        [Test]
        public void TestListMovies()
        {
            FeatureService service = new FeatureService();
            double waveId = 1;
            var results = service.ListMovies(waveId);
            var expectedResult = results.Exists(p => p.MovieNumber  == 200);
            Assert.That(expectedResult, "List Movie doesn't return any values");
        }
    }
}
