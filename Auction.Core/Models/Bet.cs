namespace Auction.Core.Models;

/// <summary>
/// Bet Model
/// </summary>
public class Bet
{
    /// <summary>
    /// Bet ID
    /// </summary>
    public int Id { get; init; }

    /// <summary>
    /// User ID who placed the bet
    /// </summary>
    public int AuthorId { get; init; }

    /// <summary>
    /// Lot ID on which the bid was made
    /// </summary>
    public int LotId { get; init; }

    /// <summary>
    /// Bet amount
    /// </summary>
    public decimal Amount { get; init; }

    /// <summary>
    /// Bet created time
    /// </summary>
    public DateTime CreatedAt { get; init; }

}
