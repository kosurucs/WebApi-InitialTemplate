using EquinityTest.Models;
using System.Collections.Generic;
using System.Linq;

namespace EquinityTest.Repository
{
    public class DbContext : IDbContext
    {
        public List<TestData> ApplicantDataSet = new List<TestData>
        {
            new TestData
            {
                Id = "3f2b12b8-2a06-45b4-b057-45949279b4e5",
                ApplicationId = 197104,
                Type = "Debit",
                Summary = "Payment",
                Amount = 58.26,
                PostingDate = "2016-07-01T00=00=00",
                IsCleared = true,
                ClearedDate = "2016-07-02T00=00=00"
            },

             new TestData
            {
                Id = "d2032222-47a6-4048-9894-11ab8ebb9f69",
                ApplicationId = 197105,
                Type = "Debit",
                Summary = "Payment",
                Amount = 50.26,
                PostingDate = "2016-07-01T00=00=00",
                IsCleared = true,
                ClearedDate = "2016-07-02T00=00=00"
            },
              new TestData
            {
                Id = "d8f156f3-bd57-49c3-9dcb-fcaaa52308f5",
                ApplicationId = 197106,
                Type = "Debit",
                Summary = "Payment",
                Amount = 59.26,
                PostingDate = "2016-07-01T00=00=00",
                IsCleared = true,
                ClearedDate = "2016-07-02T00=00=00"
            }
        };

        public bool Delete(int applicaitonId)
        {
            if (applicaitonId != 0)
            {
                var applicant = ApplicantDataSet.Where(x => x.ApplicationId == applicaitonId).FirstOrDefault();
                ApplicantDataSet.Remove(applicant);

                return true;
            }

            return false;
        }

        public TestData Get(int applicaitonId)
        {
            return ApplicantDataSet.Where(x => x.ApplicationId == applicaitonId).FirstOrDefault();
        }

        public bool Insert(TestData testData)
        {
            if (testData != null)
            {
                ApplicantDataSet.Add(testData);

                return true;
            }

            return false;
        }

        public bool Update(TestData testData)
        {
            if (testData != null)
            {
                var applicant = ApplicantDataSet.Where(x => x.ApplicationId == testData.ApplicationId).FirstOrDefault();
                ApplicantDataSet.Remove(applicant);
                ApplicantDataSet.Add(applicant);

                return true;
            }

            return false;
        }
    }
}