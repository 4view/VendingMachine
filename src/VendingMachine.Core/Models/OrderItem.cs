using System.Diagnostics.Contracts;

namespace VendingMachine.Models;

/// <summary>
/// Позиция в заказе 
/// </summary>
public class OrderItem
{
    /// <summary>
    /// Id купленного продукта
    /// </summary>
    public Guid Id { get; set ;}

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
    public Guid OrderId { get; set; }

    public Order Order { get; set; }

    /// <summary>
    /// Id продукта
    /// </summary>
    public int? ProductId { get; set; }

    public Product Product { get; set; }
}