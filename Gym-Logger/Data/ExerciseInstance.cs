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
        public int exerciseInstanceId { get; set; }

        // FK from Exercise Table
        public int exerciseId { get; set; }

        // FK from Workout Table
        public int workoutId { get; set; }

        // WeightLifting
        public double weightLifted { get; set; }
        public int repsLifted { get; set; }
        public int setsLifted { get; set; }
        public double weightAssisted { get; set; }

        // Cardio
        public double duration { get; set; }
        public int laps { get; set; }
        public double distance { get; set; }
    }
}
