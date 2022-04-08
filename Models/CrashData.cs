using Microsoft.ML.OnnxRuntime.Tensors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intex.Models
{
    public class CrashData
    {
        //public bool pedestrian_involved { get; set; }
        //public bool bicyclist_involved { get; set; }
        //public bool motorcycle_involved { get; set; }
        //public bool improper_restraint { get; set; }
        //public bool unrestrained { get; set; }
        //public bool dui { get; set; }
        //public bool intersection_related { get; set; }
        //public bool wild_animal_related { get; set; }
        //public bool overturn_rollover { get; set; }
        //public bool commercial_motor_veh { get; set; }
        //public bool older_driver { get; set; }
        //public bool single_vehicle { get; set; }
        //public bool distracted_driving { get; set; }
        //public bool drowsy_driving { get; set; }
        //public bool roadway_departure { get; set; }

        public float pedestrian_involved_True {get; set;}
        public float bicyclist_involved_True { get; set; }
        public float motorcycle_involved_True { get; set; }
        public float improper_restraint_True { get; set; }
        public float unrestrained_True { get; set; }
        public float dui_True { get; set; }
        public float intersection_related_True { get; set; }
        public float wild_animal_related_True { get; set; }
        public float overturn_rollover_True { get; set; }
        public float commercial_motor_veh_involved_True { get; set; }
        public float older_driver_involved_True { get; set; }
        public float single_vehicle_True { get; set; }
        public float distracted_driving_True { get; set; }
        public float drowsy_driving_True { get; set; }
        public float roadway_departure_True { get; set; }
        //public void AssignValues(bool pedestrian_involved, bool bicyclist_involved, bool motorcycle_involved, bool improper_restraint, bool unrestrained, bool dui, 
        //    bool intersection_related, bool wild_animal_related, bool overturn_rollover, bool commercial_motor_veh, bool older_driver, bool single_vehicle, 
        //    bool distracted_driving, bool drowsy_driving, bool roadway_departure)
        //        {
        //            pedestrian_involved_True = pedestrian_involved ? 1 : 0;
        //            bicyclist_involved_True = bicyclist_involved ? 1 : 0;
        //            motorcycle_involved_True = motorcycle_involved ? 1 : 0;
        //            improper_restraint_True = improper_restraint ? 1 : 0;
        //            unrestrained_True = unrestrained ? 1 : 0;
        //            dui_True = dui ? 1 : 0;
        //            intersection_related_True = intersection_related ? 1 : 0;
        //            wild_animal_related_True = wild_animal_related ? 1 : 0;
        //            overturn_rollover_True = overturn_rollover ? 1 : 0;
        //            commercial_motor_veh_involved_True = commercial_motor_veh ? 1 : 0;
        //            older_driver_involved_True = older_driver ? 1 : 0;
        //            single_vehicle_True = single_vehicle ? 1 : 0;
        //            distracted_driving_True = distracted_driving ? 1 : 0;
        //            drowsy_driving_True = drowsy_driving ? 1 : 0;
        //            roadway_departure_True = roadway_departure ? 1 : 0;
        //        }
        

        public Tensor<float> AsTensor()
        {
            float[] data = new float[]
            {
                pedestrian_involved_True, bicyclist_involved_True,
                motorcycle_involved_True, improper_restraint_True,
                unrestrained_True, dui_True, intersection_related_True,
                wild_animal_related_True, overturn_rollover_True,
                commercial_motor_veh_involved_True, older_driver_involved_True, 
                single_vehicle_True, distracted_driving_True, 
                drowsy_driving_True, roadway_departure_True
            };
            int[] dimensions = new int[] { 1, 15 };
            return new DenseTensor<float>(data, dimensions);
        }
    }
}
