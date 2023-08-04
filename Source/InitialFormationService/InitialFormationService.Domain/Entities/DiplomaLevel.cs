using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InitialFormationService.Domain.Entities;

public class DiplomaLevel
{
	public int Id { get; set; }
	public string Abbreviation { get; set; }
	public string Title { get; set; }
	
	public ICollection<Branch> Branches { get; set; }
}
