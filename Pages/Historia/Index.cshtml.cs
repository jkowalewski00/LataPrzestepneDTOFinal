using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using LataPrzestepne.Data;
using LataPrzestepne.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using LataPrzestepne.Interfaces;
using LataPrzestepne.ViewModels.LeapYears;

namespace LataPrzestepne.Pages.Historia
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly LataPrzestepne.Interfaces.ILeapYearsService _leapYearsService;
        private readonly ILeapYearsDTOService _leapYearsDTOService;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IConfiguration Configuration;

        public IndexModel(LataPrzestepne.Interfaces.ILeapYearsService leapYearsService, ILeapYearsDTOService leapYearsDTOService, UserManager<IdentityUser> userManager, IConfiguration configuration)
        {
            _leapYearsService = leapYearsService;
            _leapYearsDTOService = leapYearsDTOService;
            _userManager = userManager;
            Configuration = configuration;
        }

        public string CurrentUser;

        public ListLeapYearsForListVM LeapYears { get; set; }

        

        public async Task OnGetAsync(int? pageIndex)
        {
            if (_leapYearsService.isEmpty != null)
            {
                CurrentUser = _userManager.GetUserId(User);
                LeapYears = _leapYearsDTOService.GetAllRecords();
            }
        }
    }
}
