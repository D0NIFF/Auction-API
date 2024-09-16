using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Auction.API.Controllers;

/// <summary>
/// Controller for lot
/// </summary>
[Route("api/v1/users")]
[ApiController]
public class UserController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> AuthAsync()
    {
        return Ok();
    }
}
