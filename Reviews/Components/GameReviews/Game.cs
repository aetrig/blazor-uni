using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace Reviews.Components.GameReviews;

public class Game
{
	public int Id { get; set; }
	public string? Name { get; set; }
	public string? Description { get; set; }

	[DataType(DataType.Date)]
	public DateOnly? ReleaseDate { get; set; }
	public float? Rate { get; set; }

	[DataType(DataType.ImageUrl)]
	public string? ImageUrl { get; set; }
	public int RatingsCount { get; set; }
}
