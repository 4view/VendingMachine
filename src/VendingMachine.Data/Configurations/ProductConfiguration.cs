public class ProductConfiguration : IEntityTypeConfiguration<ProductEntity>
{
    public void Configure(EntityTypeBuilder<ProductEntity> builder)
    {
        builder.HasKey(p => p.Id);
        
        builder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(p => p.Price)
            .IsRequired();

        builder.Property(p => p.Image)
            .IsRequired();

        builder.Property(p => p.Quantity)
            .IsRequired();
        
        builder.HasOne(p => p.BrandEntity)
            .WithMany(b => b.ProductsEntity);
    }
}