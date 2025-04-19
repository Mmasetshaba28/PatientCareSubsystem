using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PatientCareSubsystem.Data;

namespace PatientCareSubsystem.Controllers
{
    public class VitalsController : Controller
    {
        private readonly PatientCareDbContext _context;
        public VitalsController(PatientCareDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var vitals = await _context.Vital.Include(v => v.Patient).ToListAsync();
            return View(vitals);
        }

        public async Task<IActionResult> VitalByPatientId(int PatientId)
        {
            if(Id == null || _context.Vital == null)
            {
                return NotFound();
            }

            var vital = await _context.Vital.FirstOrDefaultAsync(v => v.VitalId == PatientId);
            return View(vital);
        }
    }
}
