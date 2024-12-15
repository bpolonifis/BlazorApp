using ADHD.CoreBusiness;
using ADHD.UseCases.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ADHD.Plugins.InMemory
{
    class EmotionListRepository : IEmotionListRepository
    {
        private List<EmotionList> _emotionList;

        public EmotionListRepository()
        {
            _emotionList = new List<EmotionList>();
            {
                new EmotionList
                {
                    EmotionId = 1,
                    Date = DateTime.Now,
                    EmotionName = "Sad",
                    EmotionAction = "Sleep",
                    EmotionInformation = "heavy",
                    EmotionCommunication = "nothing",
                    EmotionRecognizion = "Slow brings Slow",
                    EmotionType = "negative",
                    EmotionStatus = false,
                    EmotionDescription = "Summary",
                    EmotionTag = "Happy",
                    EmotionTagCount = 1
                };
            };
        }

        public Task AddEmotionAsync(EmotionList emotionName)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEmotionByIdAsync(int emotionId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<EmotionList>> GetEmotionListByNameAsync(string emotionName)
        {

            if (string.IsNullOrEmpty(emotionName)) return await Task.FromResult(_emotionList);

            return _emotionList.Where(x => x.EmotionName.Contains(emotionName, StringComparison.OrdinalIgnoreCase));           
        }

        public Task<IEnumerable<EmotionList>> GetEmotionsByDescriptionAsync(string description)
        {
            throw new NotImplementedException();
        }

        public Task<EmotionList> GetEmotionsByEmotionIdAsync(int emotionId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateEmotionAsync(EmotionList emotion)
        {
            throw new NotImplementedException();
        }
    }
}
