using DofusUnlocked.API.Data.Repositories.Interfaces;
using DofusUnlocked.API.Models.Spells;
using DofusUnlocked.API.Services.Interfaces;

namespace DofusUnlocked.API.Services.Implementations;

public class SateService : IStateService
{
    private readonly IStateRepository _repository;

    public SateService(IStateRepository repository)
    {
        _repository = repository;
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