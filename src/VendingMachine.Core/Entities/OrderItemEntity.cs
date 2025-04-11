namespace VendingMachine.Entities;

/// <summary>
/// Позиция в заказе 
/// </summary>
public class OrderItemEntity
{
    /// <summary>
    /// Id купленного продукта
    /// </summary>
    public Guid Id { get; init ;}

    /// <summary>
    /// Название продукта на момент заказа
    /// </summary>
    public string ProductName { get; set; }

    /// <summary>
    /// Бренд на момент заказа
    /// </summary>
    public string BrandName { get; set; }

    /// <summary>
    /// Цена на момент заказа
    /// </summary>
    public decimal Price { get; set; }

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