using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Auction.API.Controllers;

/// <summary>
/// Controller for lot
/// </summary>
[Route("api/v1/auctions/lots")]
[ApiController]
public class LotController : ControllerBase
{

    /// <summary>
    /// Create lot
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    public async Task<IActionResult> CreateLotAsync()
    {
        return Ok();
    }

    /// <summary>
    /// Delete lot
    /// </summary>
    /// <param name="id">Lot ID</param>
    /// <returns></returns>
    [HttpDelete]
    public async Task<IActionResult> DeleteLotAsync(int id)
    {
        return Ok();
    }

    /// <summary>
    /// Update lot
    /// </summary>
    /// <returns></returns>
    [HttpPut]
    public async Task<IActionResult> UpdateLotAsync()
    {
        return Ok();
    }
}
