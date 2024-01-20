using RankingManagement.Models;
using RankingManagementApp.DAL.Interrfaces;
using RankingManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace RankingManagementApp.Controllers
{
    public class RankingController : ApiController
    {
        private readonly IRankingService _service;
        public RankingController(IRankingService service)
        {
            _service = service;
        }
        public RankingController()
        {
            // Constructor logic, if needed
        }
        [HttpPost]
        [Route("api/Ranking/CreateRanking")]
        [AllowAnonymous]
        public async Task<IHttpActionResult> CreateRanking([FromBody] Ranking model)
        {
            var leaveExists = await _service.GetRankingById(model.RankingId);
            var result = await _service.CreateRanking(model);
            return Ok(new Response { Status = "Success", Message = "Ranking created successfully!" });
        }


        [HttpPut]
        [Route("api/Ranking/UpdateRanking")]
        public async Task<IHttpActionResult> UpdateRanking([FromBody] Ranking model)
        {
            var result = await _service.UpdateRanking(model);
            return Ok(new Response { Status = "Success", Message = "Ranking updated successfully!" });
        }


        [HttpDelete]
        [Route("api/Ranking/DeleteRanking")]
        public async Task<IHttpActionResult> DeleteRanking(long id)
        {
            var result = await _service.DeleteRankingById(id);
            return Ok(new Response { Status = "Success", Message = "Ranking deleted successfully!" });
        }


        [HttpGet]
        [Route("api/Ranking/GetRankingById")]
        public async Task<IHttpActionResult> GetRankingById(long id)
        {
            var expense = await _service.GetRankingById(id);
            return Ok(expense);
        }


        [HttpGet]
        [Route("api/Ranking/GetAllRankings")]
        public async Task<IEnumerable<Ranking>> GetAllRankings()
        {
            return _service.GetAllRankings();
        }
    }
}
