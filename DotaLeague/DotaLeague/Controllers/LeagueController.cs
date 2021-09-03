using ApplicationServices.Interfaces;
using DotaLeague.Hubs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotaLeague.Controllers
{
    public class LeagueController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ILeagueService _leagueService;
        private readonly IHubContext<QueueHub, IQueueHub> _hubContext;
        private readonly IPlayerService _playerService;

        public LeagueController(ILogger<HomeController> logger,
            ILeagueService leagueService,
            IHubContext<QueueHub, IQueueHub> hubContext,
            IPlayerService playerService)
        {
            _hubContext = hubContext;
            _logger = logger;
            _playerService = playerService;
            _leagueService = leagueService;
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> LeagueQueue([FromQuery] int leagueId)
        {
            try
            {
                var leagueDTO = await _leagueService.GetLeagueWithQueueById(leagueId);

                return View(leagueDTO);
            }
            catch (Exception e)
            {
                TempData["Error"] = e.Message;
                _logger.LogError(e.Message);
                return View();
            }
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
            catch (Exception e)
            {
                //todo: proper error handling
                _logger.LogError(e.Message);
                return BadRequest(e.Message);
            }
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> LeaveQueue(int leagueId)
        {
            try
            {
                var user = User.Identity.Name;

                var playerDTO = await _playerService.LeaveQueue(user, leagueId);

                await _hubContext.Clients.All.UserDeQueued(playerDTO.PlayerId);
                
                return Ok();
            }
            catch (Exception e)
            {
                //todo: proper error handling
                _logger.LogError(e.Message);
                return BadRequest(e.Message);
            }
        }

        [Authorize(Roles = "Administrator")]
        [HttpGet]
        public async Task<IActionResult> Index()
        {

            try
            {
                var leagueDTOs = await _leagueService.GetAll();

                return View(leagueDTOs);
            }
            catch (Exception e)
            {
                TempData["Error"] = e.Message;
                _logger.LogError(e.Message);
                return View();
            }
        }

        [Authorize(Roles = "Administrator")]
        [HttpGet]
        public IActionResult CreateLeague()
        {
            return View();
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> CreateLeague(string name,
            DateTime startDateTime,
            DateTime endDateTime)
        {
            try
            {
                var user = User.Identity.Name;

                var leagueDTO = await _leagueService.CreateLeague(name, startDateTime, endDateTime);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                TempData["Error"] = e.Message;
                _logger.LogError(e.Message);
                return View();
            }
        }

        [Authorize(Roles = "Administrator")]
        [HttpGet]
        public async Task<IActionResult> DeleteLeague([FromQuery] int leagueId)
        {
            var leagueDTO = await _leagueService.GetLeagueById(leagueId);

            return View(leagueDTO);
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> DeleteLeagueConfirm(int id)
        {
            try
            {
                var user = User.Identity.Name;

                var leagueDTO = await _leagueService.DeleteLeague(id);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                TempData["Error"] = e.Message;
                _logger.LogError(e.Message);
                return RedirectToAction(nameof(Index));
            }
        }

    }
}
