using LataPrzestepne.Models;

namespace LataPrzestepne.Interfaces
{
    public interface ILeapYearsDTORepository
    {
        IQueryable<LeapYears> GetYears();
    }
}
