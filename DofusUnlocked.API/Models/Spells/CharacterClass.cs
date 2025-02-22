namespace DofusUnlocked.API.Models.Spells;

public class CharacterClass
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string ImgUrl { get; set; }
    public ICollection<Spell> Spells { get; set; }
}