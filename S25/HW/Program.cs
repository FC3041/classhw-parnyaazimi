using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace HW;

class Program
{
    static async Task Download(string link)
    {
        using var client = new HttpClient();
        string result = await client.GetStringAsync(link);
        string pattern =  @"(?:src|href)\s*=\s*[""'](?<url>[^""']+)[""']";
        var tasks = new List<Task>();
        Stopwatch sw = Stopwatch.StartNew();
        object obj = new object();
        foreach (Match match in Regex.Matches(result, pattern, RegexOptions.IgnoreCase))
        {
            tasks.Add(Task.Factory.StartNew(async () =>
                    {
                        try
                        {
                            string url = match.Groups["url"].Value;
                            string filename = Path.GetFileName(url);
                            var bytes = client.GetByteArrayAsync(url).Result;
                            await File.WriteAllBytesAsync(filename, bytes);
                            Console.WriteLine(filename + " => " + url);
                            await Download(url);
                        }
                        catch (System.AggregateException ae)
                        {
                            System.Console.WriteLine(ae.Message);
                        }
                    }
                    ));
        }
        await Task.WhenAll(tasks);
        System.Console.WriteLine($"======{sw.Elapsed.ToString()}=======");
        //======00:00:02.3574624=======
    }

    static async Task DownloadWithTask(string link)
    {
        using var client = new HttpClient();
        string result = await client.GetStringAsync(link);
        string pattern = @"(?:src)\s*=\s*[""'](?<url>https?://[^""']+)[""']";
        var tasks = new List<Task>();
        Stopwatch sw = Stopwatch.StartNew();
        object obj = new object();
        foreach (Match match in Regex.Matches(result, pattern, RegexOptions.IgnoreCase))
        {
            tasks.Add(Task.Factory.StartNew(async () =>
                    {
                        try
                        {
                            string url = match.Groups["url"].Value;
                            string filename = Path.GetFileName(url);
                            var bytes = client.GetByteArrayAsync(url).Result;
                            await File.WriteAllBytesAsync(filename, bytes);
                            Console.WriteLine(filename + " => " + url);
                        }
                        catch (System.AggregateException ae)
                        {
                            System.Console.WriteLine(ae.Message);
                        }
                    }
                    ));
        }
        await Task.WhenAll(tasks);
        System.Console.WriteLine($"======{sw.Elapsed.ToString()}=======");
        //======00:00:02.3574624=======
    }


    static async Task DownloadWithoutTask(string link)
    {
        using var client = new HttpClient();
        string result = await client.GetStringAsync(link);
        string pattern = @"(?:src)\s*=\s*[""'](?<url>https?://[^""']+)[""']";
        Stopwatch sw = Stopwatch.StartNew();
        foreach (Match match in Regex.Matches(result, pattern, RegexOptions.IgnoreCase))
        {
            try
            {
                string url = match.Groups["url"].Value;
                var bytes = client.GetByteArrayAsync(url).Result;
                string filename = Path.GetFileName(url);
                File.WriteAllBytes(filename, bytes);
                Console.WriteLine(filename + " => " + url);
            }
            catch (System.AggregateException ae)
            {
                System.Console.WriteLine(ae.Message);
            }
        }
        System.Console.WriteLine($"======{sw.Elapsed.ToString()}=======");
        //======00:00:11.5880793=======
    }

    static async Task Main(string[] arg)
    {
        await Download("https://www.tabnak.ir/");
    }
}