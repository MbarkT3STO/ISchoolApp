namespace InitialFormationService.Infrastructure.Data.EntitiesConfigs;

public class DiplomaLevelEntityConfig : IEntityTypeConfiguration<DiplomaLevel>
{
	public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<DiplomaLevel> builder)
	{
		builder.HasKey(e => e.Id);
		builder.Property(e=>e.Id).ValueGeneratedOnAdd();
		
		builder.Property(e=>e.Abbreviation).HasMaxLength(10).IsRequired();
		builder.Property(e=>e.Title).HasMaxLength(100).IsRequired();
		
		builder.HasIndex(e=>e.Title).IsUnique();
	}
}
