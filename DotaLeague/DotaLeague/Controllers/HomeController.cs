using ApplicationServices.Interfaces;
using DotaLeague.Hubs;
using DotaLeague.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DotaLeague.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHubContext<QueueHub, IQueueHub> _hubContext;
        private readonly IPlayerService _playerService;

        public HomeController(ILogger<HomeController> logger,
            IHubContext<QueueHub, IQueueHub> hubContext,
            IPlayerService playerService)
        {
            _hubContext = hubContext;
            _logger = logger;
            _playerService = playerService;
        }

        public async Task<IActionResult> Index(int leagueId)
        {
            var playerDTOs = await _playerService.GetPlayersInQueue(leagueId);

            return View(playerDTOs);
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Queue(int leagueId)
        {
            try
            {
                var user = User.Identity.Name;

                var playerDTO = await _playerService.Queue(user, leagueId);

                await _hubContext.Clients.All.UserQueued(playerDTO);

                return Ok();
            }
            catch(Exception e) 
            {
                //todo: error handling
                return Error();
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
