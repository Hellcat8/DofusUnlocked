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

    public async Task<State?> CreateStateAsync(State state)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<State>> GetAllStatesAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<State?> GetStateByIdAsync(string id)
    {
        throw new NotImplementedException();
    }

    public async Task<State?> UpdateStateAsync(int id, State state)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> DeleteStateAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task SaveAsync()
    {
        throw new NotImplementedException();
    }
}