using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Logger.Data
{
    public class ExerciseService
    {
        public Exercise GetExercise(string exerciseName)
        {
            return new Exercise
            {
                exerciseName = exerciseName,
                exerciseType = "bicep",
                exerciseEquipment = "Barbell",
                exerciseDescription = "EZ Bar Bicep Curls"
            };
        }
    }
}
