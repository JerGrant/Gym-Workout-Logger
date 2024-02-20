using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Logger.Data
{
    public class ExerciseType
    {
        // PK
        public int ExerciseTypeId { get; set; }

        // FK from Exercise Table
        public string ExerciseTypes { get; set; }
    }
}
