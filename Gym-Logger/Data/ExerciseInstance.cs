using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Logger.Data
{
    public class ExerciseInstance
    {
        // PK
        public int ExerciseInstanceId { get; set; }

        // FK from Exercise Table
        public int ExerciseId { get; set; }

        // FK from Workout Table
        public int WorkoutId { get; set; }

        // WeightLifting
        public double? WeightLifted { get; set; }
        public int? RepsLifted { get; set; }
        public int? SetsLifted { get; set; }
        public double? WeightAssisted { get; set; }

        // Cardio
        public double? Duration { get; set; }
        public int? Laps { get; set; }
        public double? Distance { get; set; }
    }
}
