using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Logger.Data
{
    public class ExerciseEquipment
    {
        // PK
        public int exerciseEquipmentId { get; set; }

        // FK from Exercise Table
        public string exerciseEquipment { get; set; }
    }
}
