using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tdot_application.Models
{
    public class EstimatedHourlyVolume
    {
        public int Id { get; set; }
        public int HourOne { get; set; }
        public int HourTwo { get; set; }
        public int HourThree { get; set; }
        public int HourFour { get; set; }
        public int HourFive { get; set; }
        public int HourSix { get; set; }
        public int HourSeven { get; set; }
        public int HourEight { get; set; }
        public int HourNine { get; set; }
        public int HourTen { get; set; }
        public int HourEleven { get; set; }
        public int HourTweleve { get; set; }
        public int HourThriteen { get; set; }
        public int HourFourteen { get; set; }
        public int HourFifteen { get; set; }
        public int HourSixteen { get; set; }
        public int HourSeventeen { get; set; }
        public int HourEighteen { get; set; }
        public int HourNineteen { get; set; }
        public int HourTwenty { get; set; }
        public int HourTwentyOne { get; set; }
        public int HourTwentyTwo { get; set; }
        public int HourTwentyThree { get; set; }
        public int HourTwentyFour { get; set; }

        public Project Project { get; set; }
        [Display(Name = "Project")]
        [Required]
        public int ProjectId { get; set; }

    }
}