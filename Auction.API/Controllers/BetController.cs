using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Auction.API.Controllers;

/// <summary>
/// Controller for lot
/// </summary>
[Route("api/v1/auctions/lots/bets")]
[ApiController]
public class BetController : ControllerBase
{

    /// <summary>
    /// Create bet
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    public async Task<IActionResult> CreateBetAsync()
    {
        return Ok();
    }

    /// <summary>
    /// Delete bet
    /// </summary>
    /// <param name="id">Bet ID</param>
    /// <returns></returns>
    [HttpDelete]
    public async Task<IActionResult> DeleteBetAsync(int id)
    {
        return Ok();
    }

    /// <summary>
    /// Update bet
    /// </summary>
    /// <returns></returns>
    [HttpPut]
    public async Task<IActionResult> UpdateBetAsync()
    {
        return Ok();
    }
}
