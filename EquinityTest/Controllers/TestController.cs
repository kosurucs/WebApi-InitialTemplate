using EquinityTest.Models;
using EquinityTest.Service;
using System;
using System.Web.Http;

namespace EquinityTest.Controllers
{
    [RoutePrefix("Applicant")]
    public class TestController : ApiController
    {
        public ITestService _testService;

        public TestController()
        {
            _testService = new TestService();
        }

        [Route("{applicationId}")]
        [HttpGet]
        public IHttpActionResult Get(int applicationId)
        {
            var resposne = _testService.GetApplicant(applicationId);
            if (resposne == null)
            {
                return Ok(string.Format("The Given Applicant ID :{0} Is Not Found", applicationId));
            }

            return Ok(resposne);
        }

        [Route("insert")]
        [HttpPost]
        public IHttpActionResult Post(TestData testData)
        {
            var response = _testService.InsertApplicant(testData);
            if (!response)
            {
                return BadRequest("The Given Applicant Data is failed while insert");
            }

            return Ok("The Given Applicant has Successfully inserted.");

        }

        [Route("update")]
        [HttpPut]
        public IHttpActionResult Put(TestData testData)
        {
            var response = _testService.UpdateApplicant(testData);
            if (!response)
            {
                return BadRequest("The Given Applicant Data is failed while update.");
            }

            return Ok("The Given Applicant has Successfully updated.");

        }

        [Route("delete/{applicationId}")]
        [HttpGet]
        public IHttpActionResult Delete(int applicationId)
        {
            var response = _testService.DeleteApplicant(applicationId);
            if (!response)
            {
                return BadRequest("The Given Applicant Data is failed while Delete");
            }

            return Ok("The Given Applicant has Successfully deleted.");

        }
    }
}
