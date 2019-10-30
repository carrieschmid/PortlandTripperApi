using System.ComponentModel.DataAnnotations;

namespace PortlandTripper.Models
{
    public class TripAdvisor
    {
        public int TripAdvisorId {get; set;}
        [Required]
        [StringLength(20)]
        public string Name {get; set;}
        [Required]
        [StringLength(20)]

        public string Hours {get; set;}
        [Required]
        [StringLength(100)]

        public string Address {get; set;}
        [Required]
        public int Cost {get; set;}
        [Required]
        [StringLength(500)]
        public string Description {get; set;}
        
    }
}