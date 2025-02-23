using DofusUnlocked.API.Models.Spells;

namespace DofusUnlocked.API.Services.Interfaces;

public interface IStateService
{
    /* Amélioration: Replace Model by DTO */
    Task<State?> CreateStateAsync(State state);
    Task<IEnumerable<State>> GetAllStatesAsync();
    Task<State?> GetStateByIdAsync(string id);
    Task<State?> UpdateStateAsync(State state);
    Task<bool> DeleteStateAsync(State state);
}