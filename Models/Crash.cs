using System;
using Microsoft.ML.OnnxRuntime.Tensors;
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

        public string Crash_Datetime { get; set; }

        public string Route { get; set; }
    
        public float? Milepoint { get; set; }

        public float? Lat_Utm_Y { get; set; }

        public float? Long_Utm_X { get; set; }

        public string Main_Road_Name { get; set; }

        public string City { get; set; }

        public string County_Name { get; set; }

        public string Crash_Severity_Id { get; set; }

        public string Work_Zone_Related { get; set; }

        public string Pedestrian_Involved { get; set; }

        public string Bicyclist_Involved { get; set; }

        public string Motorcycle_Involved { get; set; }

        public string Improper_Restraint { get; set; }

        public string Unrestrained { get; set; }

        public string DUI { get; set; }

        public string Intersection_Related { get; set; }

        public string Wild_Animal_Related { get; set; }

        public string Domestic_Animal_Related { get; set; }

        public string Overturn_Rollover { get; set; }

        public string Commercial_Motor_Veh_Involved { get; set; }

        public string Teenage_Driver_Involved { get; set; }

        public string Older_Driver_Involved { get; set; }

        public string Night_Dark_Condition { get; set; }

        public string Single_Vehicle { get; set; }

        public string Distracted_Driving { get; set; }

        public string Drowsy_Driving { get; set; }

        public string Roadway_Departure { get; set; }

        
    }
}
