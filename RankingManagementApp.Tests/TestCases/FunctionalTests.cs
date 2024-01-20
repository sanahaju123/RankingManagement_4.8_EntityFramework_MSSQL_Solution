

using RankingManagementApp.DAL.Interrfaces;
using RankingManagementApp.DAL.Services;
using RankingManagementApp.DAL.Services.Repository;
using RankingManagementApp.Models;
using RankingManagementApp.Tests.TestCases;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;
using Ranking = RankingManagementApp.Models.Ranking;

namespace RankingManagementApp.Tests.TestCases
{
    public class FunctionalTests
    {
        private readonly ITestOutputHelper _output;
        private readonly IRankingService _RankingService;
        public readonly Mock<IRankingRepository> Rankingservice = new Mock<IRankingRepository>();

        private readonly Ranking _Ranking;

        private static string type = "Functional";

        public FunctionalTests(ITestOutputHelper output)
        {
            _RankingService = new RankingService(Rankingservice.Object);

            _output = output;

            _Ranking = new Ranking
            {
                RankingId = 1,
                Name = "Sample Ranking",
                DateCreated = DateTime.Now,
                Description = "This is a sample Ranking."
            };
        }


        [Fact]
        public async Task<bool> Testfor_Create_Ranking()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                Rankingservice.Setup(repos => repos.CreateRanking(_Ranking)).ReturnsAsync(_Ranking);
                var result = await _RankingService.CreateRanking(_Ranking);
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }


        [Fact]
        public async Task<bool> Testfor_Update_Ranking()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                Rankingservice.Setup(repos => repos.UpdateRanking(_Ranking)).ReturnsAsync(_Ranking);
                var result = await _RankingService.UpdateRanking(_Ranking);
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");

            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_GetRankingById()
        {
            //Arrange
            var res = false;
            int id = 1;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                Rankingservice.Setup(repos => repos.GetRankingById(id)).ReturnsAsync(_Ranking);
                var result = await _RankingService.GetRankingById(id);
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_DeleteRankingById()
        {
            //Arrange
            var res = false;
            int id = 1;
            bool response = true;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                Rankingservice.Setup(repos => repos.DeleteRankingById(id)).ReturnsAsync(response);
                var result = await _RankingService.DeleteRankingById(id);
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

    }
}