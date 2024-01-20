using RankingManagementApp.DAL.Interrfaces;
using RankingManagementApp.DAL.Services.Repository;
using RankingManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace RankingManagementApp.DAL.Services
{
    public class RankingService : IRankingService
    {
        private readonly IRankingRepository _repository;

        public RankingService(IRankingRepository repository)
        {
            _repository = repository;
        }

        public Task<Ranking> CreateRanking(Ranking expense)
        {
            return _repository.CreateRanking(expense);
        }

        public Task<bool> DeleteRankingById(long id)
        {
            return _repository.DeleteRankingById(id);
        }

        public List<Ranking> GetAllRankings()
        {
            return _repository.GetAllRankings();
        }

        public Task<Ranking> GetRankingById(long id)
        {
            return _repository.GetRankingById(id); ;
        }

        public Task<Ranking> UpdateRanking(Ranking model)
        {
            return _repository.UpdateRanking(model);
        }
    }
}