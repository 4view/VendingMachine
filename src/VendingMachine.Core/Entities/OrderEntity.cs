namespace VendingMachine.Core.Entities;

/// <summary>
/// Заказ
/// </summary>
public class OrderEntity
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

    /// <summary>
    /// Список продуктов в заказе
    /// </summary>
    public List<OrderItemEntity> Items { get; set; }
}