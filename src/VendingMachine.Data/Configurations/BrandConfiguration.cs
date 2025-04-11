public class BrandConfiguration : IEntityTypeConfiguration<BrandEntity>
{
    public void Configure(EntityTypeBuilder<BrandEntity> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(50);
    }
}