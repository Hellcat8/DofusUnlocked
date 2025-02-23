using DofusUnlocked.API.Data.Context;
using DofusUnlocked.API.Data.Repositories.Interfaces;
using DofusUnlocked.API.Models.Spells;

namespace DofusUnlocked.API.Data.Repositories.Implementations;

public class DamageTypeRepository : IDamageTypeRepository
{
    private readonly DofusContext _context;

    public DamageTypeRepository(DofusContext context)
    {
        this._context = context;
    }

    public Task<DamageType?> CreateDamageTypeAsync(DamageType damageType)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<DamageType>> GetAllDamageTypesAsync()
    {
        throw new NotImplementedException();
    }

    public Task<DamageType?> GetDamageTypeByIdAsync(int damageTypeId)
    {
        throw new NotImplementedException();
    }

    public Task<DamageType?> UpdateDamageTypeAsync(DamageType damageType)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteDamageTypeAsync(DamageType damageType)
    {
        throw new NotImplementedException();
    }
}