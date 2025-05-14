using System;
using System.ComponentModel.DataAnnotations;

namespace GameReviews.Components.GameReviews;

public class Game
{
	public int Id { get; set; }
	public string? Title { get; set; }
	public string? Description { get; set; }
	public float? Rate { get; set; }

	[DataType(DataType.Date)]
	public DateTime? ReleaseDate { get; set; }

}
