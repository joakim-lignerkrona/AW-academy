
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3 {
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Geometry {
        public string type { get; set; }
        public List<List<double>> coordinates { get; set; }
    }

    public class Parameter {
        public string name { get; set; }
        public string levelType { get; set; }
        public int level { get; set; }
        public string unit { get; set; }
        public List<double> values { get; set; }
    }

    public class SMHIResponse {
        public DateTime approvedTime { get; set; }
        public DateTime referenceTime { get; set; }
        public Geometry geometry { get; set; }
        public List<TimeSeries> timeSeries { get; set; }
    }

    public class TimeSeries {
        public DateTime validTime { get; set; }
        public List<Parameter> parameters { get; set; }
    }



}
