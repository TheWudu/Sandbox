// See https://aka.ms/new-console-template for more information

namespace NetDownloader;

class Program
{
    static async Task Main()
    {
        NetOoeConsumptionDownloader downloader = new();
        await downloader.Login("validusername", "validpassword");
     
        var fromDate = DateTime.Parse("2026-04-01");
        var toDate = DateTime.Parse("2026-4-30");

        await downloader.DownloadCsv(fromDate, toDate, $"manager_eg_{fromDate.ToString("yyyy_MM")}.csv");
    }
}
