namespace LataPrzestepne.ViewModels.LeapYears
{
    public class LeapYearsForListVM
    {
        public int Id { get; set; }

        public string Date { get; set; }

        public string? UserID { get; set; }

        public string? UserName { get; set; }

        public int BirthYear { get; set; }

        public string? FirstName { get; set; }

        public bool LeapYear { get; set; }
    }
}
