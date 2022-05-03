namespace AlgoritmAndDiagram
{
    // Класс содержит в себе данные пользователей
    public class User
    {
        public string Login { get; set; }

        public string Name { get; set; }

        public bool IsPremium { get; set; }


        public static User Ivan = new User
        {
            Login = "Vanya123",
            Name = "Ivan",
            IsPremium = true,
        };

        public static User Alexandr = new User
        {
            Login = "Alexandr123",
            Name = "Alexandr",
            IsPremium = false,
        };

    }
}
