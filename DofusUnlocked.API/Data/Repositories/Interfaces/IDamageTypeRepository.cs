using DofusUnlocked.API.Models.Spells;

namespace DofusUnlocked.API.Data.Repositories.Interfaces;

public interface IDamageTypeRepository
{
    Task<DamageType?> CreateDamageTypeAsync(DamageType damageType);
    Task<IEnumerable<DamageType>> GetAllDamageTypesAsync();
    Task<DamageType?> GetDamageTypeByIdAsync(int damageTypeId);
    Task<DamageType?> UpdateDamageTypeAsync(DamageType damageType);
    Task<bool> DeleteDamageTypeAsync(DamageType damageType);
}