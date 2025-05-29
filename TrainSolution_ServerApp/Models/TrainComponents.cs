using System.ComponentModel.DataAnnotations;

namespace TrainSolution_ServerApp.Models
{
    public class TrainComponents
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string SerialNumber { get; set; }

        [Required]
        [MaxLength(100)]
        public string Description { get; set; }

        [Required]
        [MaxLength(10)]
        public string VehicleNumber { get; set; }

        [Required]
        public DateTime InstallDate { get; set; }

    }
}
