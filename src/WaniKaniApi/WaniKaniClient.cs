using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WaniKaniApi.Api;
using WaniKaniApi.Http;
using WaniKaniApi.Models;
using WaniKaniApi.Models.Base;
using WaniKaniApi.Models.Users;

namespace WaniKaniApi
{
    public class WaniKaniClient : IWaniKaniClient
    {
        private readonly string _apiKey;
        private readonly HttpClient _client;

        public WaniKaniClient(string apiKey)
        {
            _apiKey = apiKey;
            _client = new HttpClient(new WaniKaniHttpClientHandler())
            {
                BaseAddress = new Uri("https://api.wanikani.com/v2/"),
                DefaultRequestHeaders = {
                    Authorization = new AuthenticationHeaderValue("Bearer", _apiKey)
                },
            };

            Assignments = new AssignmentsApi(_client);
            Users = new UsersApi(_client);
            Resets = new ResetsApi(_client);
            LevelProgressions = new LevelProgressionsApi(_client);
            Reviews = new ReviewsApi(_client);
            ReviewStatistics = new ReviewStatisticsApi(_client);
            Subjects = new SubjectsApi(_client);
            Summary = new SummaryApi(_client);
            SrsStages = new SrsStagesApi(_client);
            StudyMaterials = new StudyMaterialsApi(_client);
            VoiceActors = new VoiceActorsApi(_client);
        }

        public IAssignmentsApi Assignments { get; }

        public IUsersApi Users { get; }

        public IReviewStatisticsApi ReviewStatistics { get; }

        public ILevelProgressionsApi LevelProgressions { get; }

        public IResetsApi Resets { get; }

        public ISrsStagesApi SrsStages { get; }

        public IStudyMaterialsApi StudyMaterials { get; }

        public ISubjectsApi Subjects { get; }

        public ISummaryApi Summary { get; }

        public IVoiceActorsApi VoiceActors { get; }

        public IReviewsApi Reviews { get; }
    }
}
