using System.Data;
using System.Data.SqlClient;

namespace WebApi.Repositories
{
    public class UserRepository
    {
        private IDbConnection dbConnection;

        public UserRepository(string connectionString)
        {
            this.dbConnection = new SqlConnection(connectionString);
        }
    }
}
