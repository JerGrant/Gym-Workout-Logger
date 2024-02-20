using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Logger.Data
{
    public class AppUserService
    {
        public AppUser GetAppUser(string username)
        {
            return new AppUser
            {
                UserName = username,
                Height = 70,
                Weight = 180,
                GoalWeight = 185,
                DailyCalories = 2200,
                Bmi = 25.8,
                WorkoutsCompleted = 150,
                HoursWorkedOut = 350.5,
                IbsLifted = 10450
            };
        }
    }
}
