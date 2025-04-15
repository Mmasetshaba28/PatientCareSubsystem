using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatientCareSubsystem.Models
{
    public class Medication
    {
        [Key]
        public int MedicationId { get; set; }

        [Required]
        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        public Patient Patient { get; set; }

        [Required(ErrorMessage = "Medication name is required.")]
        [StringLength(50,ErrorMessage ="Name cannot exceed 50 characters.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Dosage is required.")]
        [StringLength(30, ErrorMessage = "Dosage description cannot exceed 30 characters.")]
        public string Dosage { get; set; }
        [Range(1, 10, ErrorMessage = "Schedule must be between 1 and 10.")]
        public int Schedule { get; set; }

        [Required(ErrorMessage = "Administration date is required.")]
        [DataType(DataType.DateTime)]
        public DateTime AdministeredAt { get; set; }
    }
}
