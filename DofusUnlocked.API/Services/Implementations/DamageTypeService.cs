using DofusUnlocked.API.Data.Repositories.Interfaces;
using DofusUnlocked.API.Models.Spells;
using DofusUnlocked.API.Services.Interfaces;

namespace DofusUnlocked.API.Services.Implementations;

public class DamageTypeService : IDamageTypeService
{
    private readonly IDamageTypeRepository _repository;

    public DamageTypeService(IDamageTypeRepository repository)
    {
        _repository = repository;
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