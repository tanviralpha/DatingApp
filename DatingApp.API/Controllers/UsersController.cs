using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using DatingApp.API.Data;
using DatingApp.API.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public IDatingRepository _Repo { get; set; }
        public IMapper _Mapper { get; set; }
        public UsersController(IDatingRepository repo, IMapper mapper)
        {
            _Mapper = mapper;
            _Repo = repo;

        }

        [HttpGet]

        //IActionResult Controller action return types in ASP.NET 
        public async Task<IActionResult> GetUsers()
        {
            var users = await _Repo.GetUsers();
            var userToReturn = _Mapper.Map<IEnumerable<UserForListDto>>(users);
            return Ok(userToReturn);
        }

        [HttpGet("{Id}")]

        public async Task<IActionResult> GetUser(int Id)
        {
            var users = await _Repo.GetUser(Id);
            var userToReturn = _Mapper.Map<UserForDetailedDto>(users);
            return Ok(userToReturn);
        }
    }
}