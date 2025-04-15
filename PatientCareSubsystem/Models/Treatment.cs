using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatientCareSubsystem.Models
{
    public class Treatment
    {
        [Key]
        public int TreatmentId { get; set; }
        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        public string Description { get; set; }
        public DateTime TreatmentDate { get; set; }
    }
}
