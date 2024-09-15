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
    public List<Bet> Bets { get; init; }

    /// <summary>
    /// Lot pictures
    /// </summary>
    public IReadOnlyCollection<string> Images { get; init; }
}
