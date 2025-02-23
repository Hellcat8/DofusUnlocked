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

    public Task<Condition?> CreateConditionAsync(Condition condition)
    {
        throw new NotImplementedException();
    }

    public Task<Condition?> GetConditionByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Condition?> UpdateConditionAsync(Condition condition)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteConditionAsync(Condition condition)
    {
        throw new NotImplementedException();
    }
}