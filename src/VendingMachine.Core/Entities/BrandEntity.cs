namespace VendingMachine.Entities;

/// <summary>
/// Бренды
/// </summary>
public class BrandEntity
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
    public List<ProductEntity> ProductsEntity { get; set; }
}