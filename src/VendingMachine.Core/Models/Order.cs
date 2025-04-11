namespace VendingMachine.Core.Models;

/// <summary>
/// Заказ
/// </summary>
public class Order
{
    /// <summary>
    /// Id заказа
    /// </summary>
    public Guid Id { get; init; }

    /// <summary>
    /// Дата заказа
    /// </summary>
    public DateTimeOffset OrderDate { get; set; }

    /// <summary>
    /// Общая сумма заказа
    /// </summary>
    public decimal TotalAmount { get; set; }

    public List<OrderItem> Items { get; set; }
}