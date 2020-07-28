using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tdot_application.Models
{
    public class Project
    {
        public DateTime StartDate { get; set; }
        public int Id { get; set; }

        public string CRS { get; set; }
        
        public string Analyst { get; set; }

        public string MOTScenario { get; set; }
        
        //create new datatype later: done
        public VolumeDataType VolumeDataType { get; set; }
        public byte VolumeDataTypeId { get; set; }
        public double AadtValue { get; set; }
        
        //create new datatype later
        public HourlyDistributionType HourlyDistributionType { get; set; }
        public byte HourlyDistributionTypeId { get; set; }

        //create new datatype later
        public DirectionType DirectionType { get; set; }
        public byte DirectionTypeId { get; set; }

        public double TruckBusBaseProportion { get; set; }
        public int NumberOfLanes { get; set; }
        
        //create new datatype later
        public TerrainType TerrainType { get; set; }
        public byte TerrainTypeId { get; set; }

        public double LaneWidth { get; set; }
        public double LateralClearanceRightSide { get; set; }
        public int NumberOfLanesWithinThreeMiles { get; set; }
        public double UserDefinedAdjustment { get; set; }
        public int CalibrationOfBaseCapacity { get; set; }





    }
}