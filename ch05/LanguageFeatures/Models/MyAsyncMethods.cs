namespace LanguageFeatures.Models
{
    public class MyAsyncMethods
    {
        public async static Task<long?> GetPageLength()
        {
            HttpClient client = new HttpClient();
            var httpTask = await client.GetAsync("http://manning.com");
            return httpTask.Content.Headers.ContentLength;
        }
    }
}
