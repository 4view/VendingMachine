namespace VendingMachine.Models;

/// <summary>
/// Бренды
/// </summary>
public class Brand
{
    /// <summary>
    /// Id бренда
    /// </summary>
    public Guid Id { get; init; }

    /// <summary>
    /// Имя бренда
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Список продуктов бренда
    /// </summary>
    public List<Product> Products { get; set; }
}