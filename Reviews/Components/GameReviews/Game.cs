using System;
using System.ComponentModel.DataAnnotations;

namespace Reviews.Components.GameReviews;

public class Game
{
	public int Id { get; set; }
	public string? Name { get; set; }

	[DataType(DataType.Date)]
	public DateOnly? ReleaseDate { get; set; }
	public float? Rate { get; set; }
}
