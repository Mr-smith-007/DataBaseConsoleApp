using Microsoft.Identity.Client;

namespace ClassLibrary
{
    public static class ConnectionString
    {
        public static string MsSqlConnection => @"Server=.\SQLEXPRESS;Database=testing;Trusted_Connection=True;TrustServerCertificate=True;";  
    }
}