namespace PokemonReviewApp.Models
{
	public class Reviewer
	{
		public int Id { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }
		// If there will be more than one objects, just use ICollection type
		public ICollection<Review> Reviews { get; set; }
	}
}

