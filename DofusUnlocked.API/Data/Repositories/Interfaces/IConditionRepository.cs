using DofusUnlocked.API.Models.Spells;

namespace DofusUnlocked.API.Data.Repositories.Interfaces;

public interface IConditionRepository
{
    Task<Condition?> CreateConditionAsync(Condition condition);
    Task<Condition?> GetConditionByIdAsync(int id);
    Task<Condition?> UpdateConditionAsync(int id, Condition condition);
    Task<bool> DeleteConditionAsync(int id);
    Task SaveAsync();
}