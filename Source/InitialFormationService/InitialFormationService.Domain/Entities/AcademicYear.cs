using System;
using System.Collections.Generic;
using System.Linq; 
using System.Threading.Tasks;

namespace InitialFormationService.Domain.Entities;

public class AcademicYear
{
	public int Id { get; set; }
	public string Title { get; set; }
	public DateTime StartDate { get; set; }
	public DateTime? EndDate { get; set; }
	public bool IsCurrent { get; set; }
	public bool IsEnded { get; set; }
}
