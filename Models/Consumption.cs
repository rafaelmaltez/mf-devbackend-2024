using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_devbackend_2024.Models
{

    [Table("consumptions")]
    public class Consumption
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "A description is required")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Date is required")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Value is required")]
        public decimal Value { get; set; }

        [Required(ErrorMessage = "Km is required")]
        public int Km { get; set; }

        public FuelType Type { get; set; }

        [Display(Name = "Vehicle")]
        [Required(ErrorMessage = "You need to inform the vehicle")]
        public int VehicleId { get; set; }

        [ForeignKey("VehicleId")]
        public Vehicle Vehicle { get; set; }
    }

    public enum FuelType
    {
        Gasoline,
        Etanol
    }
}
