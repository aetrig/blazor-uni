using System;
using System.ComponentModel.DataAnnotations;

namespace Authentication.Components.Reviews;

public class Movie
{
	public int Id { get; set; }
	public string? Title { get; set; }
	public string? Description { get; set; }

	[DataType(DataType.Date)]
	public DateTime? ReleaseDate { get; set; }
	public float? Rate { get; set; }
}
