using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Intex.Models
{
    // Crash model
    public class Crash
    {
        [Key]
        [Required]
        public int Crash_Id { get; set; }

        [Required]
        public string Crash_Datetime { get; set; }

        [Required]
        public string Route { get; set; }

        [Required]
        public float Milepoint { get; set; }

        [Required]
        public float Lat_Utm_Y { get; set; }

        [Required]
        public float Long_Utm_X { get; set; }

        [Required]
        public string Main_Road_Name { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string County_Name { get; set; }

        [Required]
        public int Crash_Severity_Id { get; set; }

        [Required]
        public bool Work_Zone_Related { get; set; }

        [Required]
        public bool Pedestrian_Involved { get; set; }

        [Required]
        public bool Bicyclist_Involved { get; set; }

        [Required]
        public bool Motorcycle_Involved { get; set; }

        [Required]
        public bool Improper_Restraint { get; set; }

        [Required]
        public bool Unrestrained { get; set; }

        [Required]
        public bool DUI { get; set; }

        [Required]
        public bool Intersection_Related { get; set; }

        [Required]
        public bool Wild_Animal_Related { get; set; }

        [Required]
        public bool Domestic_Animal_Related { get; set; }

        [Required]
        public bool Overturn_Rollover { get; set; }

        [Required]
        public bool Commercial_Motor_Veh_Involved { get; set; }

        [Required]
        public bool Teenage_Driver_Involved { get; set; }

        [Required]
        public bool Older_Driver_Involved { get; set; }

        [Required]
        public bool Night_Dark_Condition { get; set; }

        [Required]
        public bool Single_Vehicle { get; set; }

        [Required]
        public bool Distracted_Driving { get; set; }

        [Required]
        public bool Drowsy_Driving { get; set; }

        [Required]
        public bool Roadway_Departure { get; set; }

    }
}
