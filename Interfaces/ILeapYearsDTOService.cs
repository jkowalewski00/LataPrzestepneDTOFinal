using LataPrzestepne.ViewModels.LeapYears;

namespace LataPrzestepne.Interfaces
{
    public interface ILeapYearsDTOService
    {
        ListLeapYearsForListVM GetAllRecords();
    }
}
