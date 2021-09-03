using ApplicationServices.ApplicationDTOs;
using ApplicationServices.Interfaces;
using DotaLeague.Models.FilterViewModels;
using DotaLeague.Models.PlayerViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotaLeague.Controllers
{
    [Authorize]
    public class PlayerController : Controller
    {
        private readonly ILogger<PlayerController> _logger;
        private readonly IPlayerService _playerService;

        public PlayerController(IPlayerService playerService,
            ILogger<PlayerController> logger)
        {
            _playerService = playerService;
            _logger = logger;
        }


        [Authorize(Roles = "Administrator")]
        [HttpGet]
        public async Task<IActionResult> Index(PlayerFiltersVM filters)
        {

            try
            {
                var playerDTOs = await _playerService.GetByFilters(
                        filters.ById,
                        filters.ByDisplayName,
                        filters.ByEmail,
                        filters.BySteamID,
                        filters.RegistratedFrom,
                        filters.RegistratedTo,
                        filters.MMRFrom,
                        filters.MMRTo,
                        filters.SortBy.ToPlayerSortBy()
                    );

                return View(new PlayerWithFiltersVM(playerDTOs, filters));
            }
            catch (Exception e)
            {
                TempData["Error"] = e.Message;
                _logger.LogError(e.Message);
                return View();
            }
        }

        [HttpGet]
        public async Task<IActionResult> Details(string email)
        {

            try
            {
                var playerDTO = await _playerService.GetPlayerByEmail(email);

                return View(playerDTO);
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
        public async Task<IActionResult> AdminEdit(string email)
        {

            try
            {
                var playerDTO = await _playerService.GetPlayerByEmail(email);

                return View(playerDTO);
            }
            catch (Exception e)
            {
                TempData["Error"] = e.Message;
                _logger.LogError(e.Message);
                return View();
            }
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> AdminEdit(PlayerEditVM player)
        {
            PlayerDTO playerDTO = null;
            try
            {
                playerDTO = await _playerService.UpdatePlayer(
                        player.Id,
                        player.DisplayName,
                        player.SteamID,
                        player.TimeOutDateTime,
                        player.VouchedLeague,
                        player.Pos1PriorityValue,
                        player.Pos2PriorityValue,
                        player.Pos3PriorityValue,
                        player.Pos4PriorityValue,
                        player.Pos5PriorityValue
                    );

                return RedirectToAction(nameof(Details), new { email = playerDTO.Email });
            }
            catch (Exception e)
            {
                TempData["Error"] = e.Message;
                _logger.LogError(e.Message);
                return View(playerDTO);
            }
        }
    }
}
