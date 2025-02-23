using DofusUnlocked.API.Models.Spells;

namespace DofusUnlocked.API.Services.Interfaces;

public interface IConditionService
{
    /* Amélioration: Replace Model by DTO */
    Task<Condition?> CreateConditionAsync(Condition condition);
    Task<Condition?> GetConditionByIdAsync(int id);
    Task<Condition?> UpdateConditionAsync(Condition condition);
    Task<bool> DeleteConditionAsync(Condition condition);
}