namespace DriverSchool.Gateway
{
    public static class ConnectionUrls
    {
        public static Dictionary<string, string> ClientUrl(IConfiguration conf) => new Dictionary<string, string>
        {
            {"http", conf["ClientUrl:AngularHTTP"] },
            {"https", conf["ClientUrl:AngularHTTPS"] }
        };

        public static Dictionary<string, string> IdentityServer(IConfiguration conf) => new Dictionary<string, string>
        {
            {"iisUrl", conf["IdentityServer:AuthorityIIS"]},
            {"kestrelUrl", conf["IdentityServer:AuthorityProfile"] }
        };
    }
}
