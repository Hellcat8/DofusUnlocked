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

    public DofusContext(DbContextOptions<DofusContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        /* Fluent API configuration */
        
        // CharacterClass
        modelBuilder.Entity<CharacterClass>()
            .HasKey(c => c.Id);

        modelBuilder.Entity<CharacterClass>()
            .Property(c => c.Name)
            .HasMaxLength(20)
            .IsRequired();

        modelBuilder.Entity<CharacterClass>()
            .Property(c => c.ImgUrl)
            .HasMaxLength(255)
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

        // State
        modelBuilder.Entity<State>()
            .HasKey(s => s.Id);
        
        modelBuilder.Entity<State>()
            .Property(s => s.Name)
            .HasMaxLength(20)
            .IsRequired();
        
        // DamageType
        modelBuilder.Entity<DamageType>()
            .HasKey(d => d.Id);
        
        modelBuilder.Entity<DamageType>()
            .Property(d => d.Name)
            .HasMaxLength(20)
            .IsRequired();
        
        modelBuilder.Entity<DamageType>()
            .Property(d => d.ImgUrl)
            .HasMaxLength(255)
            .IsRequired();
        
        // Spell
        modelBuilder.Entity<Spell>()
            .HasKey(s => s.Id);
        
        modelBuilder.Entity<Spell>()
            .Property(s => s.Name)
            .HasMaxLength(30)
            .IsRequired();

        modelBuilder.Entity<Spell>()
            .Property(s => s.Description)
            .HasMaxLength(255)
            .IsRequired();

        modelBuilder.Entity<Spell>()
            .Property(s => s.ImgUrl)
            .HasMaxLength(255)
            .IsRequired();

        modelBuilder.Entity<Spell>()
            .HasOne(s => s.CharacterClass) // A Spell has 1 CharacterClass
            .WithMany(c => c.Spells) // A CharacterClass has many Spells
            .HasForeignKey(s => s.CharacterClassId) // Foreign key in Spell
            .IsRequired();

        modelBuilder.Entity<Spell>()
            .HasOne(s => s.VariantSpell)
            .WithOne(v => v.OriginalSpell)
            .HasForeignKey<Spell>(s => s.VariantSpellId)
            .OnDelete(DeleteBehavior.SetNull) // Disable cascade deletion -> Sets FK ref to null
            .IsRequired(false);
        
        // SpellRank
        modelBuilder.Entity<SpellRank>()
            .HasKey(s => s.Id);

        modelBuilder.Entity<SpellRank>()
            .HasOne(s => s.Spell)
            .WithMany(sp => sp.SpellRanks)
            .HasForeignKey(s => s.SpellId)
            .IsRequired();

        modelBuilder.Entity<SpellRank>()
            .Property(s => s.RequiredLevel)
            .IsRequired();

        modelBuilder.Entity<SpellRank>()
            .Property(s => s.MinRange)
            .IsRequired();
        
        modelBuilder.Entity<SpellRank>()
            .Property(s => s.MaxRange)
            .IsRequired();
        
        modelBuilder.Entity<SpellRank>()
            .Property(s => s.IsRangeModifiable)
            .IsRequired();
        
        modelBuilder.Entity<SpellRank>()
            .Property(s => s.IsLineOfSightRequired)
            .IsRequired();
        
        modelBuilder.Entity<SpellRank>()
            .Property(s => s.CastInDiagonal)
            .IsRequired();
        
        modelBuilder.Entity<SpellRank>()
            .Property(s => s.CastInLine)
            .IsRequired();
        
        modelBuilder.Entity<SpellRank>()
            .Property(s => s.APCost)
            .IsRequired();
        
        modelBuilder.Entity<SpellRank>()
            .Property(s => s.MaxStack)
            .IsRequired(false);

        modelBuilder.Entity<SpellRank>()
            .Property(s => s.Cooldown)
            .IsRequired();
        
        modelBuilder.Entity<SpellRank>()
            .Property(s => s.GlobalCooldown)
            .IsRequired();
        
        modelBuilder.Entity<SpellRank>()
            .Property(s => s.CanCastOnEmptyCell)
            .IsRequired();
        
        // EffectType
        modelBuilder.Entity<EffectType>()
            .HasKey(e => e.Id);

        modelBuilder.Entity<EffectType>()
            .Property(e => e.Name)
            .HasMaxLength(100)
            .IsRequired();
        
        // SpellEffect
        modelBuilder.Entity<SpellEffect>()
            .HasKey(s => s.Id);
        
        modelBuilder.Entity<SpellEffect>()
            .HasOne(s => s.SpellRank)
            .WithMany()
            .HasForeignKey(s => s.SpellRankId)
            .IsRequired();
        
        modelBuilder.Entity<SpellEffect>()
            .HasOne(s => s.EffectType)
            .WithMany()
            .HasForeignKey(s => s.EffectTypeId)
            .IsRequired();
        
        modelBuilder.Entity<SpellEffect>()
            .HasOne(s => s.DamageType)
            .WithMany()
            .HasForeignKey(s => s.DamageTypeId)
            .IsRequired(false);
        
        modelBuilder.Entity<SpellEffect>()
            .HasOne(s => s.State)
            .WithMany()
            .HasForeignKey(s => s.StateId)
            .IsRequired(false);
        
        modelBuilder.Entity<SpellEffect>()
            .Property(s => s.EffectOrder)
            .IsRequired();
        
        modelBuilder.Entity<SpellEffect>()
            .Property(s => s.MinValue)
            .IsRequired(false);
        
        modelBuilder.Entity<SpellEffect>()
            .Property(s => s.MaxValue)
            .IsRequired(false);
        
        modelBuilder.Entity<SpellEffect>()
            .Property(s => s.Value)
            .IsRequired(false);
        
        modelBuilder.Entity<SpellEffect>()
            .Property(s => s.Duration)
            .IsRequired(false);
    }
}