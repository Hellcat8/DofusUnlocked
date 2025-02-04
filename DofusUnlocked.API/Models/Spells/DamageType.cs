public class DamageType
{
    public int Id { get; set; } // Primary Key
    public required string Name { get; set; } // Fire, Pushback, Water ...
    public required string ImgUrl { get; set; } // Damage type icon url
}