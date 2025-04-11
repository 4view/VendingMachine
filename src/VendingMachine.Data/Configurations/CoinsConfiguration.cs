public class CoinsConfigurations : IEntityTypeConfiguration<CoinsEntity>
{
    public void Configure(EntityTypeBuilder<CoinsEntity> builder)
    {
        builder.Property(p => p.Denomination)
            .IsRequired()
            .HasColumnType("decimal(18,2)");
            
        builder.Property(p => p.Count)
            .IsRequired();
    }
}