﻿namespace LanguageFeatures.Models
{
    public class MyAsyncMethods
    {
        public async static Task<long?> GetPageLength()
        {
            HttpClient client = new HttpClient();
            var httpTask = await client.GetAsync("http://manning.com");
            return httpTask.Content.Headers.ContentLength;
        }

        public static async IAsyncEnumerable<long?> GetPageLengths(
            List<string> output, 
            params string[] urls)
        {
            List <long?> results = new List<long?>();
            HttpClient client = new HttpClient();
            foreach (string url in urls)
            {
                output.Add($"Started request for {url}");
                var httpMessage = await client.GetAsync($"http://{url}");
                results.Add(httpMessage.Content.Headers.ContentLength);
                output.Add($"Completed request for {url}");
                yield return httpMessage.Content.Headers.ContentLength;
            }
        }
    }
}
