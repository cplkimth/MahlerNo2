namespace MahlerNo2.Data
{
    public partial class DbContextFactory
    {
        static DbContextFactory()
        {
            #if DEBUG
            RawConnectionString = "Data Source=210.119.12.52;Initial Catalog=MahlerNo2;Persist Security Info=True;User ID=mahler;Password=no2";
            #else            
            RawConnectionString = "";
            #endif
        }

        public static string RawConnectionString { get; private set; }

        public static void ChangeIpAddress(string ip)
        {
            RawConnectionString = $"Data Source={ip};Initial Catalog=MahlerNo2;uid=mahler;password=no2";
        }

        static partial void GetConnectionStringCore(ref string connectionString)
        {
            connectionString =
                $"metadata=res://*/MahlerNo2.csdl|res://*/MahlerNo2.ssdl|res://*/MahlerNo2.msl;provider=System.Data.SqlClient;provider connection string=\"{RawConnectionString};MultipleActiveResultSets=True;App=EntityFramework\"";
        }

        static partial void CreateCore(MahlerNo2Entities context)
        {
        }
    }
}