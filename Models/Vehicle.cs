using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_devbackend_2024.Models
{
    [Table("vehicles")]
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Name is mandatoy")]
        public string Name { get; set; }

        [Required(ErrorMessage = "PlateNumber is mandatoy")]
        public int PlateNumber { get; set; }

        [Required(ErrorMessage = "MakeYear is mandatoy")]
        public int MakeYear { get; set; }

        [Required(ErrorMessage = "ModelYear is mandatoy")]
        public int ModelYear { get; set; }
    }
}
