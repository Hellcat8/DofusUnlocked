using System.Collections.Immutable;
using DofusUnlocked.API.Models.Spells;
using Microsoft.EntityFrameworkCore;

namespace DofusUnlocked.API.Data.Context;

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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Fluent API configuration
        
        // CharacterClass
        modelBuilder.Entity<CharacterClass>()
            .HasKey(c => c.Id);

        modelBuilder.Entity<CharacterClass>()
            .Property(c => c.Name)
            .HasMaxLength(20)
            .IsRequired();

        modelBuilder.Entity<CharacterClass>()
            .Property(c => c.ImgUrl)
            .IsRequired();
        
        // Condition
        modelBuilder.Entity<Condition>()
            .HasKey(c => c.Id);
        
        modelBuilder.Entity<Condition>()
            .Property(c => c.ConditionValue)
            .IsRequired();

        modelBuilder.Entity<Condition>()
            .HasOne(c => c.State) // Une Condition a un Etat
            .WithMany(s => s.Conditions) // Un Etat a plusieurs Conditions
            .HasForeignKey(c => c.StateId) // Clé étrangère dans Conditions
            .IsRequired();
    }
}