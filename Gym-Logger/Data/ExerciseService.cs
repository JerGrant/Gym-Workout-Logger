using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Logger.Data
{
    public class ExerciseService
    {
        public static Exercise GetExercise(string exerciseName)
        {
            return new Exercise
            {
                ExerciseName = exerciseName,
                ExerciseTypeId = "bicep",
                ExerciseEquipmentId = "Barbell",
                ExerciseDescription = "EZ Bar Bicep Curls"
            };
        }
    }
}
