using DofusUnlocked.API.Models.Spells;

namespace DofusUnlocked.API.Services.Interfaces;

public interface IDamageTypeService
{
    /* Amélioration: Replace Model by DTO */
    Task<DamageType?> CreateDamageTypeAsync(DamageType damageType);
    Task<IEnumerable<DamageType>> GetAllDamageTypesAsync();
    Task<DamageType?> GetDamageTypeByIdAsync(int damageTypeId);
    Task<DamageType?> UpdateDamageTypeAsync(int id, DamageType damageType);
    Task<bool> DeleteDamageTypeAsync(int id);
    Task SaveAsync();
}