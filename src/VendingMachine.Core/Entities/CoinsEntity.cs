namespace VendingMachine.Core.Entities;

/// <summary>
/// Монеты
/// </summary>
public class CoinsEntity
{
    /// <summary>
    /// Id монеты
    /// </summary>
    public Guid Id { get; init; }

    /// <summary>
    /// Номинал монеты
    /// </summary>
    public decimal Denomination { get; set; }

    /// <summary>
    /// Количество монет определенного номинала
    /// </summary>
    public int Count { get; set; }

    /// <summary>
    /// Заблокирована ли монета, если она закончилась
    /// </summary>
    public bool isBlocked { get; set; }
}