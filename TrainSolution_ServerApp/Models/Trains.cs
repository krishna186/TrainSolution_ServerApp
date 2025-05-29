using System.ComponentModel.DataAnnotations;

namespace TrainSolution_ServerApp.Models
{
    public class Trains
    {
        [Key]
        [MaxLength(10)]
        public string VehicleNumber { get; set; }

        [Required]
        [MaxLength(50)]
        public string FleetName { get; set; }

        [Required]
        public DateTime DateIntoService { get; set; }

        [Required]
        public DateTime DateEndsService { get; set; }

    }
}
