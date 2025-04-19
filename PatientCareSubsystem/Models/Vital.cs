using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PatientCareSubsystem.Models
{
    public class Vital
    {
        [Key]
        public int VitalId { get; set; }

        [Required]
        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        public Patient Patient { get; set; }

        [Required(ErrorMessage = "Date and time of recording is required.")]
        [DataType(DataType.DateTime)]
        public DateTime RecordedAt { get; set; }

        [Required(ErrorMessage = "Blood pressure is required.")]
        [StringLength(10, ErrorMessage = "BP format should be like '120/80'.")]
        [Precision(18, 2)]
        public decimal BloodPressure { get; set; }

        [Required(ErrorMessage = "Temperature is required.")]
        [Range(34, 43, ErrorMessage = "Temperature must be between 34 and 43 °C.")]
        [Precision(18, 2)]
        public decimal Temperature { get; set; }

        [Required(ErrorMessage = "Sugar level is required.")]
        [Range(1, 30, ErrorMessage = "Sugar level must be between 1 and 30 mmol/L.")]
        [Precision(18, 2)]
        public decimal SugarLevel { get; set; }
    }
}
