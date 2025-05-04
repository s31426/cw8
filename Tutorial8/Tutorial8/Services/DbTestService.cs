using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
namespace Tutorial8.Services;

using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

public class DbTestService
{
    private readonly IConfiguration _configuration;

    public DbTestService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public bool TestConnection()
    {
        using var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
        try
        {
            connection.Open();
            return true;
        }
        catch
        {
            return false;
        }
    }
}
