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
        public int ExerciseId {  get; set; }

        // FK from Exercise Table
        public int ExerciseInstanceId { get; set; }

        // Exercise Identifiers
        public string ExerciseName {  get; set; }
        public string ExerciseTypeId { get; set; }
        public string ExerciseEquipmentId { get; set; }
        public string? ExerciseDescription { get; set;}

        // Exercise Media
        public string? ExerciseImg { get; set; }
        public string? ExerciseVid { get; set; }
    }
}
