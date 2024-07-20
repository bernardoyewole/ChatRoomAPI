using DAL;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ChatRoom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IGenericRepository<ApplicationUser> _genericUserRepository;
        
        public UserController(IGenericRepository<ApplicationUser> genericUserRepository)
        {
            _genericUserRepository = genericUserRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _genericUserRepository.GetAll();

            return Ok(users);
        }
    }
}
