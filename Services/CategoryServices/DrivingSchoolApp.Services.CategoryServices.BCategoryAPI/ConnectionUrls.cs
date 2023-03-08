namespace DrivingSchoolApp.Services.CategoryServices.BCategoryAPI
{
    public static class ConnectionUrls
    {
        public static Dictionary<string, string> ClientUrl(IConfiguration conf) => new Dictionary<string, string>
        {
            {"http", conf["ClientUrl:AngularHTTP"] },
            {"https", conf["ClientUrl:AngularHTTPS"] }
        };
    }
}
