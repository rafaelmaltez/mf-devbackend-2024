using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_devbackend_2024.Models
{
    [Table("vehicles")]
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is mandatoy")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "PlateNumber is mandatoy")]
        [Display(Name = "Plate Number")]
        public int PlateNumber { get; set; }

        [Required(ErrorMessage = "MakeYear is mandatoy")]
        [Display(Name = "Fabrication Year")]
        public int MakeYear { get; set; }

        [Required(ErrorMessage = "ModelYear is mandatoy")]
        [Display(Name = "Model Year")]
        public int ModelYear { get; set; }
    }
}
