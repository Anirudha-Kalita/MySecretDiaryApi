using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace MySecretDiaryApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DiaryController : ControllerBase
    {
        [HttpGet("public")]
        public IActionResult GetPublicEntry()
        {
            return Ok("This is a public diary entry. Anyone can see this!");
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("secret")]
        public IActionResult GetSecretEntry()
        {
            // We can get the user's ID from the token's claims
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            return Ok($"This is a TOP SECRET diary entry for user '{userId}'. Only admins can see this!");
        }
    }
}