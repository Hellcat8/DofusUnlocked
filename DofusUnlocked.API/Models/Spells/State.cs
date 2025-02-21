namespace DofusUnlocked.API.Models.Spells;

public class State // Etat pesanteur, invulnérable etc
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public ICollection<Condition> Conditions { get; set; }
}