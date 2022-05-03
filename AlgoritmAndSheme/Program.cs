namespace AlgoritmAndDiagram
{
    internal class Program
    {
       static string login;
       static User CurrentUser;

       public static List<User> users = new List<User> { User.Alexandr, User.Ivan };

       static void Main()
        {
            Console.WriteLine("Логины доля проверки: \nAlexandr123\tVanya123 \nВведите логин:");

            login = Console.ReadLine();

            // Ищем в листе пользователей пользователя с введенным логином
            try
            {
                CurrentUser = users.First(user => user.Login == login);
            }

            // Не нашли пользователя, снова переходим к вводу логина
            catch
            {
                Console.WriteLine("Пользователь не найден");
                Main();
            }
            Console.WriteLine($"Здравствуйте, {CurrentUser.Name}");
            if (!CurrentUser.IsPremium)
            {
                ShowAds();
            }

            Console.ReadLine();
        }

       static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
}