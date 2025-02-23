using DofusUnlocked.API.Data.Context;
using DofusUnlocked.API.Data.Repositories.Interfaces;
using DofusUnlocked.API.Models.Spells;

namespace DofusUnlocked.API.Data.Repositories.Implementations;

public class StateRepository : IStateRepository
{
    private readonly DofusContext _context;

    public StateRepository(DofusContext context)
    {
        _context = context;
    }

    public Task<State?> CreateStateAsync(State state)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<State>> GetAllStatesAsync()
    {
        throw new NotImplementedException();
    }

    public Task<State?> GetStateByIdAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task<State?> UpdateStateAsync(State state)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteStateAsync(State state)
    {
        throw new NotImplementedException();
    }
}