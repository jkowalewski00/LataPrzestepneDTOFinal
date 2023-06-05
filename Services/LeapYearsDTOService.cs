using LataPrzestepne.Interfaces;
using LataPrzestepne.ViewModels.LeapYears;

namespace LataPrzestepne.Services
{
    public class LeapYearsDTOService : ILeapYearsDTOService
    {
        private readonly ILeapYearsDTORepository _leapYearsRepo;

        public LeapYearsDTOService(ILeapYearsDTORepository leapYearsRepo)
        {
            _leapYearsRepo = leapYearsRepo;
        }   

        public ListLeapYearsForListVM GetAllRecords() 
        {
            var pom = _leapYearsRepo.GetYears();
            ListLeapYearsForListVM result = new ListLeapYearsForListVM();   
            result.List = new List<LeapYearsForListVM>();
            foreach (var year in pom)
            {
                var yVM = new LeapYearsForListVM()
                {
                    Id = year.Id,   
                    Date = year.Date,
                    UserID = year.UserID,
                    UserName = year.UserName,
                    BirthYear = year.BirthYear,
                    FirstName = year.FirstName,
                    LeapYear = year.LeapYear
                };
                result.List.Add(yVM);
            }

            return result;
        }
    }
}
