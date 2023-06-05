using LataPrzestepne.Data;
using LataPrzestepne.Interfaces;
using LataPrzestepne.Models;

namespace LataPrzestepne.Repositories
{
    public class LeapYearsDTORepository : ILeapYearsDTORepository
    {
        private readonly ApplicationDbContext _context;

        public LeapYearsDTORepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IQueryable<LeapYears> GetYears()
        {
            return _context.LeapYears.AsQueryable();
        }
    }
}
