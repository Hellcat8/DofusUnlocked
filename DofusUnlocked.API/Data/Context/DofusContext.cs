using Microsoft.EntityFrameworkCore;

public class DofusContext : DbContext
{
    public DbSet<CharacterClass> CharacterClasses { get; set; }
    public DbSet<Spell> Spells { get; set; }
    public DbSet<SpellRank> SpellRanks { get; set; }
    public DbSet<SpellEffect> SpellEffects { get; set; }
    public DbSet<EffectType> EffectTypes { get; set; }
    public DbSet<DamageType> DamageTypes { get; set; }
    public DbSet<Condition> Conditions { get; set; }
    public DbSet<State> States { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(
            "server=localhost;port=3306;user=root;database=DofusUnlockedProd",
            ServerVersion.AutoDetect("server=localhost;port=3306;user=root;database=DofusUnlockedProd")
        );
    }
}