using Form5.Data;
using Form5.Models;
using Microsoft.EntityFrameworkCore;

namespace Form5.Service
{
    public class SafetyService
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public SafetyService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<Safety>> GetAllSafety()
        {
            return await _applicationDbContext.Safety.ToListAsync();
        }

        public async Task<bool> AddNewSafety(Safety safety)
        {
            await _applicationDbContext.Safety.AddAsync(safety);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Safety> GetEmployeeById(int id)
        {
            Safety safety = await _applicationDbContext.Safety.FirstOrDefaultAsync(x => x.Id == id);
            return safety;
        }

        public async Task<bool> UpdateSafetyDetails(Safety safety)
        {
            _applicationDbContext.Safety.Update(safety);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteSafety(Safety safety)
        {
            _applicationDbContext.Safety.Remove(safety);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }
    }
}
