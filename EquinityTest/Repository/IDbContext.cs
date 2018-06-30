using EquinityTest.Models;

namespace EquinityTest.Repository
{
    public interface IDbContext
    {
        TestData Get(int applicaitonId);

        bool Insert(TestData testData);

        bool Update(TestData testData);

        bool Delete(int applicaitonId);
    }
}
