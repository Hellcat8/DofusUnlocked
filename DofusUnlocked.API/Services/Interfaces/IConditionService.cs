using DofusUnlocked.API.Models.Spells;

namespace DofusUnlocked.API.Services.Interfaces;

public interface IConditionService
{
    /* Amélioration: Replace Model by DTO */
    Task<Condition?> CreateConditionAsync(Condition condition);
    Task<Condition?> GetConditionByIdAsync(int id);
    Task<Condition?> UpdateConditionAsync(int id, Condition condition);
    Task<bool> DeleteConditionAsync(int id);
    Task SaveAsync();
}