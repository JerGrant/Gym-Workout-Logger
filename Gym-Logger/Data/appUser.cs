namespace Gym_Logger.Data
{
    public class appUser
    {
        // Identifiers
        public string UserName { get; set; }
        public string ProfileImg? {  get; set; }
        // User Attributes
        public double Height? { get; set; }
        public double Weight? { get; set; }
        public double GoalWeight? { get; set; }
        public int DailyCalories? { get; set; }
        public double BMI? {  get; set; }
        // Gameify fields
        public int WorkoutsCompleted? { get; set; }
        public double HoursWorkedOut? { get; set; }
        public double IbsLifted? {  get; set; }
    }
}