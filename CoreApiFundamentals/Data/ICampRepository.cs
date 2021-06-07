using CoreApiFundamentals.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApiFundamentals.Data
{
    public interface ICampRepository
    {
        //General
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();

        //Camps
        Task<Camp[]> GetAllCampAsync(bool includeTalks = false);
        Task<Camp> GetCampAsync(string Moniker, bool includeTalks = false);
        Task<Camp[]> GetAllCampsByEventDate(DateTime dateTime, bool includeTalks = false);

        // Talks
        Task<Talk> GetTalkByMonikerAsync(string Moniker, int talkId, bool includeSpeakers = false);
        Task<Talk[]> GetTalksByMonikerAsync(string moniker, bool includeSpeakers = false);

        // Speakers
        Task<Speaker[]> GetSpeakersByMonikerAsync(string Moniker);
        Task<Speaker> GetSpeakerAsync(int speakerId);
        Task<Speaker[]> GetAllSpeakersAsync();
    }
}
