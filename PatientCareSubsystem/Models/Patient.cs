using System.ComponentModel.DataAnnotations;

namespace PatientCareSubsystem.Models
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Date of Birth is required.")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public bool IsOnChronicMed {  get; set; }

        [Required]
        public bool IsAdmitted { get; set; }
        public DateTime? AdmitDate { get; set; }

        public ICollection<Vital> Vital { get; set; }
        public ICollection<Treatment> Treatments { get; set; }
        public ICollection<Medication> Medications { get; set; }
        public ICollection<DoctorInstruction> DoctorInstructions { get; set; }
    }
}
