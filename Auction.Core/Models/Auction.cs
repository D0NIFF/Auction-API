namespace Auction.Core.Models;


/// <summary>
/// Auction Model
/// </summary>
public class Auction
{

    /// <summary>
    /// Auction ID
    /// </summary>
    public int Id { get; init; }

    /// <summary>
    /// Auction Name
    /// </summary>
    public string Name { get; init; }

    /// <summary>
    /// Auction author ID
    /// </summary>
    public int AuthorId { get; init; }

    /// <summary>
    /// Auction created time
    /// </summary>
    public DateTime DateStart { get; init; }

    /// <summary>
    /// Flag, is the auction now being processed
    /// </summary>
    public bool IsCreation { get; init; }

    private readonly DateTime _dateEnd;

    /// <summary>
    /// Auction complete time
    /// </summary>
    public DateTime DateEnd 
    { 
        get
        {
            /* 
             * Auction auto-renewal logic. If a bid is made 30 seconds or less before the end of the auction, we extend it
             * by 30 seconds to avoid the situation when users will try to bid at the end of the auction.
             */
            var maxBetDate = Lots.Values.SelectMany(l => l.Bets).Max(s => s.CreatedAt).AddSeconds(30);
            return _dateEnd > maxBetDate ? _dateEnd : maxBetDate;
        }
        init => _dateEnd = value;
    }

    /// <summary>
    /// Auction status
    /// </summary>
    public AuctionStatus Status
    {
        get
        {
            if (IsCreation)
                return AuctionStatus.Creation;

            DateTime dateTimeNow = DateTime.UtcNow;

            if (dateTimeNow > DateStart && dateTimeNow < DateEnd)
                return AuctionStatus.Bidding;

            if (dateTimeNow < DateStart)
                return AuctionStatus.WaitBidding;

            return AuctionStatus.Complete;
        }
    }

    /// <summary>
    /// Auction lots
    /// </summary>
    public Dictionary<int, Lot> Lots { get; init; } = new();
}


