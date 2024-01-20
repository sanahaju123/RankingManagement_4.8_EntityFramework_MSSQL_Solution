using RankingManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RankingManagementApp.DAL.Services.Repository
{
    public interface IRankingRepository
    {
        List<Ranking> GetAllRankings();
        Task<Ranking> CreateRanking(Ranking expense);
        Task<Ranking> GetRankingById(long id);
        Task<bool> DeleteRankingById(long id);
        Task<Ranking> UpdateRanking(Ranking model);
    }
}

