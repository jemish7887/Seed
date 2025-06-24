using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebApplication7.Data;
using WebApplication7.Interfaces;
using WebApplication7.Models;
using WebApplication7.Repository;

namespace WebApplication7.Controllers
{
    public class ClubController : Controller
    {
        private readonly IClubRepository _clubRepository;

        public ClubController(IClubRepository clubRepository)          
        {
            _clubRepository = clubRepository;
        }
        public async Task<IActionResult> Index()
        {
           IEnumerable<Club>clubs=await _clubRepository.GetAll();    
            return View(clubs);
        }
        public async Task<IActionResult> Detail(int id)
        {
            Club club = await _clubRepository.GetByIdAsync(id);
            return View(club);
        }
    }
}
