using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InitialFormationService.Infrastructure.Data.Entities;

public class DiplomaLevel
{
	public int Id { get; set; }
	public string Abbreviation { get; set; }
	public string Title { get; set; }

	public virtual ICollection<Branch> Branches { get; set; }
}
