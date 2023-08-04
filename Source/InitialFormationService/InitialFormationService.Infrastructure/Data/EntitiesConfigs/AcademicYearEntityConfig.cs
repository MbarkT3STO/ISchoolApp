using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InitialFormationService.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InitialFormationService.Infrastructure.Data.EntitiesConfigs;

public class AcademicYearEntityConfig : IEntityTypeConfiguration<AcademicYear>
{
	public void Configure(EntityTypeBuilder<AcademicYear> builder)
	{
		builder.HasKey(e => e.Id);
		builder.Property(e=>e.Id).ValueGeneratedOnAdd();
	
		builder.Property(e=>e.Title).HasMaxLength(50).IsRequired();
		builder.Property(e=>e.StartDate).IsRequired();
		builder.Property(e=>e.IsCurrent).IsRequired();
		builder.Property(e=>e.IsEnded).IsRequired();
		
		builder.HasIndex(e=>e.Title).IsUnique();
	}
}
