namespace Auction.Core.Models;

/// <summary>
/// User Model
/// </summary>
public class User
{
    /// <summary>
    /// User ID
    /// </summary>
    public int Id { get; init; }

    /// <summary>
    /// User login
    /// </summary>
    public string Login { get; init; }

    /// <summary>
    /// User E-mail
    /// </summary>
    public string Email { get; init; }

    /// <summary>
    /// User password hash
    /// </summary>
    public string PasswordHash { get; init; }
}
