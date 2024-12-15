using ADHD.CoreBusiness;

namespace ADHD.UseCases.PluginInterfaces
{
    public interface IEmotionListRepository
    {
        Task AddEmotionAsync(EmotionList emotionName);
        Task DeleteEmotionByIdAsync(int emotionId);
        Task<IEnumerable<EmotionList>> GetEmotionsByDescriptionAsync(string description);
        Task<EmotionList> GetEmotionsByEmotionIdAsync(int emotionId);
        Task UpdateEmotionAsync(EmotionList emotion);
    
    }
}