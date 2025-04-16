using VendingMachine.Core.Entities;

namespace VendingMachine.Core.Models;

/// <summary>
/// Продукт
/// </summary>
public class Product
{
    public ProductEntity _entity;

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
    /// Изображение продукта
    /// </summary>
    public string Image { get; set; }

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

    public Product CreateFrom(ProductEntity entity)
    {
        var newProductModel = new Product()
        {
            Name = entity.Name,
            Price = entity.Price,
            Image = entity.Image,
            Quantity = entity.Quantity
        };

        newProductModel._entity = entity;

        return newProductModel;
    }

    public ProductEntity ToEntity()
    {
        if(_entity == null)
            _entity = new ProductEntity();

        _entity.Name = Name;
        _entity.Price = Price;
        _entity.Image = Image;
        _entity.Quantity = Quantity;
        
        return _entity;
    }

    public override string ToString()
    {
        return Image + "\n" + Name + "\n" + Price;
    }
}