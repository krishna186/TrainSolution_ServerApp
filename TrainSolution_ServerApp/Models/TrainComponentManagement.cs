using Microsoft.EntityFrameworkCore;
using TrainSolution_ServerApp.Models.Data;

namespace TrainSolution_ServerApp.Models
{
    // Service Layer for managing train components.
    public class TrainComponentManagement
    {
        private readonly ApplicationDbContext _db;
        public TrainComponentManagement(ApplicationDbContext db)
        {
            _db = db; // Injecting the database context using constructor injection
        }
        public async Task<List<TrainComponents>> GetComponents(string? vehicleFilter = null, DateTime? from = null, DateTime? to = null)
        {
            var query = _db.TrainComponents.AsQueryable();

            // Applying filters based on Fleet Name and installation date range
            if (!string.IsNullOrWhiteSpace(vehicleFilter))
            {
                query = (from a in _db.TrainComponents
                         join b in _db.Trains
                         on a.VehicleNumber equals b.VehicleNumber
                         where b.FleetName.ToLower().Contains(vehicleFilter.ToLower())
                         select a);
            }
            if (from.HasValue)
            {
                query = query.Where(c => c.InstallDate >= from.Value);
            }
            if (to.HasValue)
            {
                query = query.Where(c => c.InstallDate <= to.Value);
            }

            return await query.OrderBy(c => c.SerialNumber).ToListAsync();
        }      
        public async Task AddComponent(TrainComponents component)
        {
            _db.TrainComponents.Add(component);
            await _db.SaveChangesAsync();
        }
        public async Task DeleteComponent(int id)
        {
            var component = await _db.TrainComponents.FindAsync(id);
            if (component != null)
            {
                _db.TrainComponents.Remove(component);
                await _db.SaveChangesAsync();
            }
        }
        public async Task<TrainComponents?> GetComponentById(int id)
        {
            return await _db.TrainComponents.FindAsync(id);
        }

        public async Task UpdateComponent(TrainComponents component)
        {
            _db.TrainComponents.Update(component);
            await _db.SaveChangesAsync();
        }
        public async Task<DashboardSummary> GetDashboardSummary()
        {
            // This method calculates the dashboard summary for train components using Linq.
            var components = await _db.TrainComponents.ToListAsync();

            var totalVehicles = components.Select(c => c.VehicleNumber).Distinct().Count();

            var avgComponentsPerVehicle = components.GroupBy(c => c.VehicleNumber)
                                                     .Average(g => g.Count());

            var minDateinService = (from a in _db.TrainComponents
                                    join b in _db.Trains
                                    on a.VehicleNumber equals b.VehicleNumber
                                    select b.DateIntoService).Min();

            var maxDateinService = (from a in _db.TrainComponents
                                    join b in _db.Trains
                                    on a.VehicleNumber equals b.VehicleNumber
                                    select b.DateEndsService).Max();

            var vehicles = await _db.Trains.ToListAsync();

            double AvgVehicaleAge = Math.Round( vehicles
                .Select(c => (c.DateEndsService - c.DateIntoService).TotalDays / 365)
                .Average());


            return new DashboardSummary
            {
                TotalVehicles = totalVehicles,
                AvgComponentsPerVehicle = Math.Round(avgComponentsPerVehicle,2),
                 EarliestDateInService= minDateinService,
                LastDateInService = maxDateinService,
                AvgVehicleAge = AvgVehicaleAge
            };
        }

        public async Task<List<string>> GetAllVehicleNumbers()
        {
            // This method retrieves all distinct vehicle numbers from the database to bind dropdown in AddComponents Page.
            return await _db.Trains.Select(c => c.VehicleNumber).Distinct().ToListAsync();
        }
    }
}
