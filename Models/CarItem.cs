using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cardata_api_v3.Models
{
    public class CarItem
    {
        public long Id { get; set; }
        public string Company { get; set; }
        public string BodyType { get; set; }
        public string Model { get; set; }
        public string Fuel { get; set; }
        public string Engine { get; set; }
        public Nullable<int> EngineYearI { get; set; }
        public Nullable<int> EngineYearF { get; set; }
        public string Co2EemissionsUm { get; set; }
        public Nullable<int> Co2Eemissions { get; set; }
        public Nullable<int> MaxPowerKw { get; set; }
        public Nullable<int> MaxPowerBhp { get; set; }
        public Nullable<int> MaxTorqueNm { get; set; }
        public Nullable<int> TopSpeedKmph { get; set; }
        public Nullable<double> Zero100 { get; set; }
        public Nullable<int> ModelYearI { get; set; }
        public Nullable<int> ModelYearF { get; set; }
        public string Generation { get; set; }
        public string PhotoLink { get; set; }
    }
}
