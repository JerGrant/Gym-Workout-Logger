using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Logger.Data
{
    internal class Workout
    {
        // PK
        public int workoutId { get; set; }

        // FK from AppUser
        public int userId { get; set; }

        // Identifier
        public string workoutName { get; set; }

        // Workout timestamps
        public DateTime workoutDate { get; set; }
        public double workoutDuration { get; set; }

        // Flags 
        public bool isInProgress { get; set; }
        public bool isCompleted { get; set; }
        public DateTime createdAt { get; set; }

        // Gameify
        public double ibsLifted { get; set; }
    }
}
