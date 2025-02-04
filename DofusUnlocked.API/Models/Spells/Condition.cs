public class Condition // ex. Condition: Ne possède pas l'état Pesanteur, Possède l'état Invulnérable etc.
{
    public int Id { get; set; }
    public bool ConditionValue { get; set; }

    // Relation to State
    public int StateId { get; set; } // FK to State
    public State State { get; set; } = null!; // Navigation Property
}