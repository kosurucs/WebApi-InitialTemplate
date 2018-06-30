using EquinityTest.Models;

namespace EquinityTest.Service
{
    public interface ITestService
    {
        TestData GetApplicant(int applicationId);

        bool InsertApplicant(TestData testData);

        bool UpdateApplicant(TestData testData);

        bool DeleteApplicant(int applicationId);
    }
}
