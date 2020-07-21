using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tdot_application.Models;

namespace Tdot_application.ViewModels
{
    public class ProjectAndVolumeDataViewModel
    {
        public Project Project { get; set; }
        public List<EstimatedHourlyVolume> EstimatedHourlyVolumes { get; set; }

    }
}