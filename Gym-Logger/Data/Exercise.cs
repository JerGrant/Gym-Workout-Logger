using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Logger.Data
{
    public class Exercise
    {
        // PK
        public int exerciseId {  get; set; }

        // FK from Exercise Table
        public int exerciseInstanceId { get; set; }

        // Exercise Identifiers
        public string exerciseName {  get; set; }
        public string exerciseTypeId { get; set; }
        public string exerciseEquipmentId { get; set; }
        public string? exerciseDescription { get; set;}

        // Exercise Media
        public string? exerciseImg { get; set; }
        public string? exerciseVid { get; set; }
    }
}
