


using RankingManagementApp.DAL.Interrfaces;
using RankingManagementApp.DAL.Services;
using RankingManagementApp.DAL.Services.Repository;
using RankingManagementApp.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;
using Ranking = RankingManagementApp.Models.Ranking;

namespace RankingManagementApp.Tests.TestCases
{
    public class ExceptionalTests
    {
        private readonly ITestOutputHelper _output;
        private readonly IRankingService _RankingService;
        public readonly Mock<IRankingRepository> Rankingservice = new Mock<IRankingRepository>();

        private readonly Ranking _Ranking;

        private static string type = "Exception";

        public ExceptionalTests(ITestOutputHelper output)
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
        public async Task<bool> Testfor_Validate_ifInvalidRankingIdIsPassed()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                Rankingservice.Setup(repo => repo.CreateRanking(_Ranking)).ReturnsAsync(_Ranking);
                var result = await _RankingService.CreateRanking(_Ranking);
                if (result != null || result.RankingId !=0)
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
        public async Task<bool> Testfor_Validate_ifInvalidNameIsPassed()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                Rankingservice.Setup(repo => repo.CreateRanking(_Ranking)).ReturnsAsync(_Ranking);
                var result = await _RankingService.CreateRanking(_Ranking);
                if (result != null || result.Name !=null)
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
        public async Task<bool> Testfor_Validate_ifInvalidDescriptionIsPassed()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                Rankingservice.Setup(repo => repo.CreateRanking(_Ranking)).ReturnsAsync(_Ranking);
                var result = await _RankingService.CreateRanking(_Ranking);
                if (result != null || result.Description !=null)
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
        public async Task<bool> Testfor_Validate_ifInvalidRankingDateIsPassed()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                Rankingservice.Setup(repo => repo.CreateRanking(_Ranking)).ReturnsAsync(_Ranking);
                var result = await _RankingService.CreateRanking(_Ranking);
                if (result != null || result.DateCreated !=null)
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