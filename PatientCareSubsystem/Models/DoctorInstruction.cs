using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatientCareSubsystem.Models
{
    public class DoctorInstruction
    {
        [Key]
        public int InstructionId { get; set; }

        [Required]
        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        public Patient Patient { get; set; }

        [Required(ErrorMessage = "Instruction content is required.")]
        [StringLength(500)]
        public string Instructions { get; set; }

        [Required(ErrorMessage = "Date and time of instruction is required.")]
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; }

        [Required(ErrorMessage = "Doctor's name is required.")]
        [StringLength(100)]
        public string GivenBy { get; set; }
    }
}
