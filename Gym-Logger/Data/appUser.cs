namespace Gym_Logger.Data {
    public class AppUser {
        // PKS
        public int userId {  get; set; }

        // Identifiers
        public string userName { get; set; }
        public string? profileImg {  get; set; }

        // User Attributes
        public double? height { get; set; }
        public double? weight { get; set; }
        public double? goalWeight { get; set; }
        public int? dailyCalories { get; set; }
        public double? bmi {  get; set; }

        // Gameify fields
        public int? workoutsCompleted { get; set; }
        public double? hoursWorkedOut { get; set; }
        public double? ibsLifted {  get; set; }
    }
}
