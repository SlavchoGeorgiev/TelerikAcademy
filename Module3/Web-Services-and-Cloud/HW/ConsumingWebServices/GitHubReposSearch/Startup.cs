namespace GitHubReposSearch
{
    using System;
    using System.Net.Http;
    using Newtonsoft.Json;

    public class Startup
    {
        public static void Main()
        {
            WebRequestHandler handler = new WebRequestHandler()
            {
                UseProxy = true,
            };

            var httpClient = new HttpClient(handler);

            httpClient.BaseAddress = new Uri("https://api.github.com/");
            httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            httpClient.DefaultRequestHeaders.UserAgent.Add(new System.Net.Http.Headers.ProductInfoHeaderValue("Mozilla", "5.0"));

            Console.WriteLine("Searching in GitHub repositories.");
            Console.Write("Please enter key word: ");
            var userInput = Console.ReadLine().Trim();

            PrintSearchResult(httpClient, userInput);

            Console.ReadLine();
            PrintSearchResult(httpClient, "Arduino+Windows+language:C#");

            Console.ReadLine();
        }

        public static string GenereteSearchResurce(string query, string sort = "stars", string order = "desc")
        {
            return string.Format("search/repositories?q={0}&order={1}&sort={2}", query, order, sort);
        }

        public static async void PrintSearchResult(HttpClient httpClient, string query)
        {
            var searchResurce = GenereteSearchResurce(query);
            
            var response = await httpClient.GetAsync(searchResurce);

            var responseJson = JsonConvert.DeserializeObject<RepoSearchResponseModel>(response.Content.ReadAsStringAsync().Result);

            Console.WriteLine("Results: {0}", responseJson.Total_Count);
            Console.WriteLine();

            foreach (var item in responseJson.Items)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Html_Url);
            }
        }
    }
}
