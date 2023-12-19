using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Logger.Data
{
    public class Exercise
    {
        // Exercise Identifiers
        public string exerciseName {  get; set; }
        public string exerciseType { get; set; }
        public string? exerciseEquipment { get; set; }
        public string? exerciseDescription { get; set;}
        // Exercise Media
        public string? exerciseImg { get; set; }
        public string? exerciseVid { get; set; }
    }
}
