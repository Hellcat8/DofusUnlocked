using DofusUnlocked.API.Data.Repositories.Interfaces;
using DofusUnlocked.API.Models.Spells;
using DofusUnlocked.API.Services.Interfaces;

namespace DofusUnlocked.API.Services.Implementations;

public class ConditionService : IConditionService
{
    private readonly IConditionRepository _repository;

    public ConditionService(IConditionRepository repository)
    {
        _repository = repository;
    }

    public async Task<Condition?> CreateConditionAsync(Condition condition)
    {
        throw new NotImplementedException();
    }

    public async Task<Condition?> GetConditionByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<Condition?> UpdateConditionAsync(int id, Condition condition)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> DeleteConditionAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task SaveAsync()
    {
        throw new NotImplementedException();
    }
}