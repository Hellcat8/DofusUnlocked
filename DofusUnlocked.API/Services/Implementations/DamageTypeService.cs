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