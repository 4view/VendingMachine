public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItemEntity>
{
    public void Configure(EntityTypeBuilder<OrderItemEntity> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Quantity)
            .IsRequired();

        builder.HasOne(p => p.OrderEntity)
            .WithMany(p => p.Items)
            .HasForeignKey(p => p.OrderEntityId);
    }
}