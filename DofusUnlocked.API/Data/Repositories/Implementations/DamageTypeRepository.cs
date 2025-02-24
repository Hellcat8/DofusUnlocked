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

    public async Task<DamageType?> CreateDamageTypeAsync(DamageType damageType)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<DamageType>> GetAllDamageTypesAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<DamageType?> GetDamageTypeByIdAsync(int damageTypeId)
    {
        throw new NotImplementedException();
    }

    public async Task<DamageType?> UpdateDamageTypeAsync(int id, DamageType damageType)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> DeleteDamageTypeAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task SaveAsync()
    {
        throw new NotImplementedException();
    }
}