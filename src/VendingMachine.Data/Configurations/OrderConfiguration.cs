public class OrderConfiguration : IEntityTypeConfiguration<OrderEntity>
{
    public void Configure(EntityTypeBuilder<OrderEntity> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.OrderDate)
            .IsRequired();

        builder.Property(p => p.TotalAmount)
            .IsRequired();
    }
}