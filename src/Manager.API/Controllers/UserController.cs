using Manager.API.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Manager.Core.Exceptions;
using Manager.Services.Interfaces;
using Manager.Services.DTO;
using AutoMapper;
using Manager.API.Utilities;


namespace Manager.API.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
        public UserController(IUserService userService, IMapper mappper)
        {
            _userService = userService;
            _mappper = mappper;
        }

        private readonly IUserService _userService;

        private readonly IMapper _mappper;
        
        
        [HttpPost]
        [Route("/api/v1/users/create")]

        public async Task<IActionResult> Create([FromBody] CreateUserViewModel userViewModel)
        {
            try
            {
                var userDTO = _mappper.Map<UserDTO>(userViewModel);
                var userCreated = await _userService.Create(userDTO);
                return Ok(new ResultViewModel
                {
                    Message = "User created",
                    Success = true,
                    Data = userCreated
                });
            }
            catch (DomainException ex)
            {
                return BadRequest(Responses.DomainErrorMessage(ex.Message, ex.Errors));
            }
            catch (Exception)
            {
                return StatusCode(500, Responses.ApplicationErrorMessage());
            }
        }
        
    }

    
}

