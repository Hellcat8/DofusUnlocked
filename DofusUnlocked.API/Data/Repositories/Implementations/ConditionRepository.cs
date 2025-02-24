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