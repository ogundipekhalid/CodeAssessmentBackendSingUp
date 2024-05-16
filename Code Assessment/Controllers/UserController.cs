using Code_Assessment.Dto;
using Code_Assessment.Interface.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Code_Assessment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserServices _userServices;

        public UserController(IUserServices userServices)
        {
            _userServices = userServices;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> LoginAsync([FromForm] LogingRequesteModel model)
        {
            var log = await _userServices.Login(model);
            if (log.Status)
            {
                return Ok(log);
            }
            return BadRequest(log);
        }
    }
}
