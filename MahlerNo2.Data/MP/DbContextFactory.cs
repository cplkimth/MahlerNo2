namespace MahlerNo2.Data
{
    public partial class DbContextFactory
    {
        static DbContextFactory()
        {
#if DEBUG
            RawConnectionString = "Data Source=cn76.ipdisk.co.kr,3423;Initial Catalog=MahlerNo2;uid=mahler;password=no2";
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