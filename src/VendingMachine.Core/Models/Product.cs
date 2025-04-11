namespace VendingMachine.Core.Models;

/// <summary>
/// Продукт
/// </summary>
public class Product
{
    public Guid Id { get; init; }
    /// <summary>
    /// Название продукта
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Цена продукта
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// Количесвто продукта в автомате 
    /// </summary>
    public int Quantity { get; set; }

    /// <summary>
    /// Id бренда
    /// </summary>
    public Guid BrandId { get; init; }
    
    /// <summary>
    /// Бренд товара
    /// </summary>
    public Brand Brand { get; set; }
}