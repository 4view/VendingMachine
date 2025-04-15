public class CoinsConfigurations : IEntityTypeConfiguration<CoinsEntity>
{
    public void Configure(EntityTypeBuilder<CoinsEntity> builder)
    {
        builder.Property(p => p.Denomination)
            .IsRequired()
            .HasColumnType("decimal(18,0)");
            
        builder.Property(p => p.Count)
            .IsRequired();
        
        builder.Property(p => p.isBlocked)
            .IsRequired();
    }
}