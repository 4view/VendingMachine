namespace VendingMachine.Core.Models;

/// <summary>
/// Позиция в заказе 
/// </summary>
public class OrderItem
{
    /// <summary>
    /// Id купленного продукта
    /// </summary>
    public Guid Id { get; init ;}

    /// <summary>
    /// Количества купленного продукта
    /// </summary>
    public int Quantity { get; set; }

    /// <summary>
    /// Id заказа
    /// </summary>
    public Guid OrderId { get; set; }

    public Order Order { get; set; }

    /// <summary>
    /// Id продукта
    /// </summary>
    public int? ProductId { get; set; }

    public Product Product { get; set; }
}