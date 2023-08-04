using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InitialFormationService.Domain.Entities;

public class Branch
{
	public int Id { get; set; }
	public string Title { get; set; }
	public byte FormativeYears { get; set; }
	public byte FormativeMonths { get; set; }
}
