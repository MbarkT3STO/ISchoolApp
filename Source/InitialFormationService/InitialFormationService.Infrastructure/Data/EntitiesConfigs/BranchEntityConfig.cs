using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InitialFormationService.Infrastructure.Data.EntitiesConfigs;

public class BranchEntityConfig : IEntityTypeConfiguration<Branch>
{
	public void Configure(EntityTypeBuilder<Branch> builder)
	{
		builder.HasKey(e => e.Id);
		builder.Property(e => e.Id).ValueGeneratedOnAdd();

		builder.Property(e => e.Abbreviation).HasMaxLength(10).IsRequired();
		builder.Property(e => e.Title).HasMaxLength(100).IsRequired();
		builder.Property(e => e.FormativeYears).IsRequired();

		builder.Property(e => e.FormativeMonths).IsRequired();


		builder.HasOne(e => e.DiplomaLevel).WithMany(e => e.Branches).HasForeignKey(e => e.DiplomaLevelId);


		builder.HasIndex(e => e.Title).IsUnique();
		
		builder.ToTable("Branches", t =>
		{
			t.HasCheckConstraint("CK_Branch_FormativeYears", "\"FormativeYears\">= 0");
			t.HasCheckConstraint("CK_Branch_FormativeMonths", "\"FormativeMonths\">= 0");
		});

	}
}
