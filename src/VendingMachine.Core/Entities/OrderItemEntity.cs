namespace VendingMachine.Core.Entities;

/// <summary>
/// Позиция в заказе 
/// </summary>
public class OrderItemEntity
{
    /// <summary>
    /// Id купленного продукта
    /// </summary>
    public Guid Id { get; init; }

    /// <summary>
    /// Количества купленного продукта
    /// </summary>
    public int Quantity { get; set; }

    /// <summary>
    /// Id заказа
    /// </summary>
    public Guid OrderEntityId { get; set; }

    public OrderEntity OrderEntity { get; set; }

    /// <summary>
    /// Id продукта
    /// </summary>
    public int? ProductEntityId { get; set; }

    public ProductEntity ProductEntity { get; set; }
}