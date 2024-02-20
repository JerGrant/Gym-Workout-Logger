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
        public int WorkoutId { get; set; }

        // FK from AppUser
        public int UserId { get; set; }

        // Identifier
        public string WorkoutName { get; set; }

        // Workout timestamps
        public DateTime WorkoutDate { get; set; }
        public double WorkoutDuration { get; set; }

        // Flags 
        public bool IsInProgress { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime CreatedAt { get; set; }

        // Gameify
        public double? IbsLifted { get; set; }
    }
}
