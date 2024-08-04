using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Extensions;
using api.interfaces;
using api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/portfolio")]
    [ApiController]
    public class PortofolioController: ControllerBase
    {   
        private readonly UserManager<AppUser> _userManager;
        private readonly IStockRepository _stockRepo;
        private readonly IPortofolioRepository _portofolioRepo;
        public PortofolioController(UserManager<AppUser> userManager, IStockRepository stockRepo, IPortofolioRepository portofolioRepo)
        {
            _userManager =userManager;
             _stockRepo=stockRepo;
             _portofolioRepo = portofolioRepo;
        }
        [HttpGet]
        [Authorize]

        public async Task<IActionResult> GetUserPortofolio()
        {
            var username = User.GetUsername();
            var appUser = await _userManager.FindByNameAsync(username);
            
            var userPortofolio= await _portofolioRepo.GetUserPortofolio(appUser);

            return Ok(userPortofolio);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddPortofolio(string symbol)
        {
            var username = User.GetUsername();
            var appUser = await _userManager.FindByNameAsync(username);
            var stock = await _stockRepo.GetBySymbolAsync(symbol);

            if(stock == null)
                return BadRequest("Stock not found");

            var userPortofolio = await _portofolioRepo.GetUserPortofolio(appUser);
            if(userPortofolio.Any(e => e.Symbol.ToLower() == symbol.ToLower()))
                 return BadRequest("Cannot add same stock portofolio");
            var portofolioModel = new Portofolio
            {
                StockId = stock.Id,
                AppUserId = appUser.Id
            };

            await _portofolioRepo.CreateAsync(portofolioModel);

            if(portofolioModel == null)
            {
                return StatusCode(500, "Could not create");
            }
            else{
                return Created();
            }

        }

        [HttpDelete]
        [Authorize]

        public async Task<IActionResult> DeletePortofolio(string symbol)
        {
            var username = User.GetUsername();
            var appUser = await _userManager.FindByNameAsync(username);

            var userPortofolio = await _portofolioRepo.GetUserPortofolio(appUser);

            var filterdStock = userPortofolio.Where(s=> s.Symbol.ToLower() == symbol.ToLower()).ToList();

            if(filterdStock.Count() == 1)
            {
                await _portofolioRepo.DeletePortofolio(appUser, symbol);
            }else {

                return BadRequest("Stock not in your portofolio");
            }
            return Ok();
        }

    }
}