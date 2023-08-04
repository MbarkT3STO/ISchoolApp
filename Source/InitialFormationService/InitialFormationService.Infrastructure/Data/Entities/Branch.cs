using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InitialFormationService.Infrastructure.Data.Entities;

public class Branch
{
	public int Id { get; set; }
	public string Abbreviation { get; set; }
	public string Title { get; set; }
	public byte FormativeYears { get; set; }
	public byte FormativeMonths { get; set; }
	
	public int DiplomaLevelId { get; set; }

	public virtual DiplomaLevel DiplomaLevel { get; set; }
}
