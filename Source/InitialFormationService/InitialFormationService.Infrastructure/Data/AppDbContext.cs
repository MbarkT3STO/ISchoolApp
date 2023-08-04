namespace InitialFormationService.Infrastructure.Data;

public class AppDbContext : DbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
	{
	}
	
	// Apply the configuration for all entities
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
	}
	
	
	public DbSet<AcademicYear> AcademicYears { get; set; }
	public DbSet<DiplomaLevel> DiplomaLevels { get; set; }
	public DbSet<Branch> Branches { get; set; }
}
