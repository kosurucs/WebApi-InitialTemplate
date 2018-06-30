using System;
using EquinityTest.Models;
using EquinityTest.Repository;

namespace EquinityTest.Service
{
    public class TestService : ITestService
    {
        public IDbContext _dbContext;

        public TestService()
        {
            _dbContext = new DbContext();
        }

        public bool DeleteApplicant(int applicationId)
        {
            return _dbContext.Delete(applicationId);
        }

        public TestData GetApplicant(int applicationId)
        {
            return _dbContext.Get(applicationId);
        }

        public bool InsertApplicant(TestData testData)
        {
            return _dbContext.Insert(testData);
        }

        public bool UpdateApplicant(TestData testData)
        {
            return _dbContext.Update(testData);
        }
    }
}