namespace DofusUnlocked.API.Models.Spells;

public class EffectType
{
    public int Id { get; set; } // Primary Key
    public required string Name { get; set; } // Repousse de X cases, État Pesanteur, Dommages air, -2PM etc.
}