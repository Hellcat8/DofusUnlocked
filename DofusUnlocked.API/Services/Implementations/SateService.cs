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