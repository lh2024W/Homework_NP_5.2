namespace Homework_NP_5._2
{
    class Program
    {
        static HttpClient httpClient = new HttpClient();
        static async Task Main()
        {
            Console.WriteLine("Введите url адрес страницы: ");
            string url = Console.ReadLine();
            // получаем ответ
            using HttpResponseMessage response = await httpClient.GetAsync(url);
            // получаем ответ
            string content = await response.Content.ReadAsStringAsync();
            Console.WriteLine(content);
        }
    }

}
