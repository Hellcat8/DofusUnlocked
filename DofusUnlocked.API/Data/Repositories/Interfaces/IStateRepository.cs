using DofusUnlocked.API.Models.Spells;

namespace DofusUnlocked.API.Data.Repositories.Interfaces;

public interface IStateRepository
{
    Task<State?> CreateStateAsync(State state);
    Task<IEnumerable<State>> GetAllStatesAsync();
    Task<State?> GetStateByIdAsync(string id);
    Task<State?> UpdateStateAsync(State state);
    Task<bool> DeleteStateAsync(State state);
}