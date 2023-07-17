namespace PokemonReviewApp.Models
{
    public class Owner
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Gym { get; set; }
        // If it is only one object, just use its prototype
        public Country Country { get; set; }
        // Many to Many relationships
        public ICollection<PokemonOwner> PokemonOwners { get; set; }
    }
}

