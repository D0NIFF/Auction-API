using FluentResults;
namespace Auction.Core.Models;

/// <summary>
/// Lot Model
/// </summary>
public class Lot
{
    /// <summary>
    /// Lot ID
    /// </summary>
    public int Id { get; init; }

    public int AuctionId { get; init; }

    /// <summary>
    /// Auction ID
    /// </summary>
    public string Name { get; init; }

    /// <summary>
    /// Code
    /// </summary>
    public string Code { get; init; }

    /// <summary>
    /// Lot name
    /// </summary>
    public string Description { get; init; }

    /// <summary>
    /// Lot status
    /// </summary>
    public LotStatus Status { get; init; }

    /// <summary>
    /// Lot bets
    /// </summary>
    public IReadOnlyCollection<Bet> Bets => _Bets;

    private List<Bet> _Bets = new List<Bet>();

    /// <summary>
    /// Lot pictures
    /// </summary>
    public IReadOnlyCollection<string> Images { get; init; } = new List<string>();

    /// <summary>
    /// Attempting to place a bet
    /// </summary>
    /// <param name="bet">Bet</param>
    /// <returns>The result of the operation execution. If bidding on the lot is completed or a bid with this size has already been made, it will return an Fail</returns>
    public Result TryDoBet(Bet bet)
    {
        if (Status != LotStatus.Complete)
            return Result.Fail("It is impossible to bid on this lot, because the auction is closed");

        if (_Bets.Any(b => b.Amount >= bet.Amount))
            return Result.Fail("Your bid has been overridden, try again later");

        _Bets.Add(bet); 
        return Result.Ok();
    }
}
