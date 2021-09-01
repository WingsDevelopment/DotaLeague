using ApplicationServices.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotaLeague.ViewComponents
{
    public class LeagueNavBarViewComponent : ViewComponent
    {
        private readonly ILeagueService _leagueService;

        public LeagueNavBarViewComponent(ILeagueService leagueService)
        {
            _leagueService = leagueService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            try
            {
                var leagueDTOs = await _leagueService.GetAll();
                return View(leagueDTOs);
            }
            catch (Exception e)
            {
                return View(e);
            }
        }
    }
}
