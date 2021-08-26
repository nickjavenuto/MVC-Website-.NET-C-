using System.Data.Entity;
using System.Data.Entity.SqlServer; 

namespace SampleSPCWebApplication.DAL
{
    public class SchoolConfiguration : DbConfiguration
    {
        public SchoolConfiguration()
        {
            SetExecutionStrategy("System.Data.SqlCLient", () => new SqlAzureExecutionStrategy()); 
        }
    }
}