using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkflowBll.ZFeature.Repository
{
    public abstract class FeatureRepository<T>
    {
        public abstract T ListFeature(double lineId);
        public abstract List<T> ListFeatures(double waveId);

    }
}
