using WebApplication7.Data.Enum;
using WebApplication7.Models;

namespace WebApplication7.ViewModel
{
    public class CreateClubViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Address Address { get; set; }    
        public IFormFile Image { get; set; } 
        public ClubCategory ClubCategory { get; set; }  
    }
}
