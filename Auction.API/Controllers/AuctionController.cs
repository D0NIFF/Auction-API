using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Auction.API.Controllers;

/// <summary>
/// Controller for auction
/// </summary>
[Route("api/v1/[controller]")]
[ApiController]
public class AuctionController : ControllerBase
{

    /// <summary>
    /// Create auction
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    public async Task<IActionResult> CreateAuctionAsync()
    {
        return Ok();
    }

    /// <summary>
    /// Delete auction
    /// </summary>
    /// <param name="id">Auction ID</param>
    /// <returns></returns>
    [HttpDelete]
    public async Task<IActionResult> DeleteAuctionAsync(int id)
    {
        return Ok();
    }

    /// <summary>
    /// Update auction
    /// </summary>
    /// <returns></returns>
    [HttpPut]
    public async Task<IActionResult> UpdateAuctionAsync()
    {
        return Ok();
    }

    [HttpGet("details")]
    public async Task<IActionResult> GetAuctionsAsync()
    {
        return Ok(); 
    }

    [HttpGet]
    public async Task<IActionResult> GetAuctionsAsyncWithDetails()
    {
        return Ok();
    }
}
