using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WebApplication7.Data;
using WebApplication7.Interfaces;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class RaceController : Controller
    {
        private IRaceRepository _raceRepository;

        public RaceController(IRaceRepository raceRepository)
        {
            _raceRepository = raceRepository;
        }
            
        
        public  async Task <IActionResult> Index()
        {  IEnumerable<Race>races = await _raceRepository.GetAll();
            return View(races);
        }
        public async Task<IActionResult> Detail(int id)
        {
            Race race = await _raceRepository.GetByIdAsync(id);
            return View(race);
        }

    } 

}
