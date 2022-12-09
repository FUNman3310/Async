namespace AsyncTask
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //var task = Task.Run(() =>
            //{
            //    Console.WriteLine("Salam, AB102");
            //});
            //task.Wait();
            //Console.ReadLine();


            var data =  GetStringDataAsync();
            //Console.WriteLine(data);

            while (data.IsCompleted)
            {
                Console.WriteLine("Conntinue");
            }
            Console.WriteLine("Finish");


            Console.WriteLine("Hloooooow");
            //var data = await GetStringData();
            //Console.WriteLine(data);

            
        }

        static async Task<string> GetStringDataAsync()
        {
            HttpClient client = new HttpClient();
            return await client.GetStringAsync("https://github.com/FUNman3310/Async");
        }

        static async Task<string> GetStringData()
        {
            HttpClient client = new HttpClient();
            var data = client.GetStringAsync("https://github.com/FUNman3310/Async").Result;
            return data;
        }

    }
}
