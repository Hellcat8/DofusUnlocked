using DofusUnlocked.API.Models.Spells;

namespace DofusUnlocked.API.Data.Repositories.Interfaces;

public interface IConditionRepository
{
    Task<Condition?> CreateConditionAsync(Condition condition);
    Task<Condition?> GetConditionByIdAsync(int id);
    Task<Condition?> UpdateConditionAsync(Condition condition);
    Task<bool> DeleteConditionAsync(Condition condition);
}