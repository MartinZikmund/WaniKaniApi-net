using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaniKaniApi.Api;
using WaniKaniApi.Models;
using WaniKaniApi.Models.Users;

namespace WaniKaniApi
{
    public interface IWaniKaniClient
    {
        IAssignmentsApi Assignments { get; }

        ILevelProgressionsApi LevelProgressions { get; }

        IUsersApi Users { get; }

        IReviewsApi Reviews { get; }

        IReviewStatisticsApi ReviewStatistics { get; }

        IResetsApi Resets { get; }

        ISrsStagesApi SrsStages { get; }

        IStudyMaterialsApi StudyMaterials { get; }

        ISubjectsApi Subjects { get; }

        ISummaryApi Summary { get; }

        IVoiceActorsApi VoiceActors { get; }
    }
}
