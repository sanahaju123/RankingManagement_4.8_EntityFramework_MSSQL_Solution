using RankingManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace RankingManagementApp.DAL.Services.Repository
{
    public class RankingRepository : IRankingRepository
    {
        private readonly DatabaseContext _dbContext;
        public RankingRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<Ranking> CreateRanking(Ranking expense)
        {
            try
            {
                var result =  _dbContext.Rankings.Add(expense);
                await _dbContext.SaveChangesAsync();
                return expense;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<bool> DeleteRankingById(long id)
        {
            try
            {
                _dbContext.Rankings.Remove(_dbContext.Rankings.Single(a => a.RankingId == id));
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public List<Ranking> GetAllRankings()
        {
            try
            {
                var result = _dbContext.Rankings.ToList();
                return result;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<Ranking> GetRankingById(long id)
        {
            try
            {
                return await _dbContext.Rankings.FindAsync(id);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

      
        

        public async Task<Ranking> UpdateRanking(Ranking model)
        {
            var ex = await _dbContext.Rankings.FindAsync(model.RankingId);
            try
            {
                await _dbContext.SaveChangesAsync();
                return ex;
            }
            catch (Exception exc)
            {
                throw (exc);
            }
        }
    }
}