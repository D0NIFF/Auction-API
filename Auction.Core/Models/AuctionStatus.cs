namespace Auction.Core.Models;

/// <summary>
/// Auction status
/// </summary>
public enum AuctionStatus
{
    /// <summary>
    /// Unknown status
    /// </summary>
    Unknown = 0,

    /// <summary>
    /// Auction creation phase
    /// </summary>
    Creation = 1,

    /// <summary>
    /// Pending bidding phase
    /// </summary>
    WaitBidding = 2,

    /// <summary>
    /// Bidding phase
    /// </summary>
    Bidding = 3,

    /// <summary>
    /// The auction is over
    /// </summary>
    Complete = 4
}


