namespace TrainSolution_ServerApp.Models
{
    public class DashboardSummary
    {
        public int TotalVehicles { get; set; }
        public double AvgComponentsPerVehicle { get; set; }
        public DateTime EarliestDateInService { get; set; }
        public DateTime LastDateInService { get; set; }
        public double AvgVehicleAge { get; set; }
    }
}
