namespace VendingMachine.Data;

public class ApplicationContext : DbContext
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(
                Assembly.GetExecutingAssembly()
        );
    }
}