using DofusUnlocked.API.Data.Context;
using DofusUnlocked.API.Data.Repositories.Interfaces;
using DofusUnlocked.API.Models.Spells;

namespace DofusUnlocked.API.Data.Repositories.Implementations;

public class ConditionRepository : IConditionRepository
{
    private readonly DofusContext _context;

    public ConditionRepository(DofusContext context)
    {
        _context = context;
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