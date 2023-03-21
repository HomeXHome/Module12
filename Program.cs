namespace Module12
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AdHandler adHandler = new();

            User TestUser1 = new User("qwerty1", "FirstGuy", true);
            User TestUser2 = new User("asdfgh1", "SecondGuy", false);
            User TestUser3 = new User("zxcvb1", "TrirdGuy", true);

            var userList = new User[] { TestUser1, TestUser2, TestUser3 };

            foreach (var user in userList)
            {
                if (user.IsPremium)
                    Console.WriteLine($"Добро пожаловать, {user.Name}!");
                else
                {
                    Console.WriteLine("Для доступа к сервису просмотрите рекламу или купите Премиум доступ.");
                    adHandler.ShowAds();
                    Console.WriteLine($"Добро пожаловать, {user.Name}!");
                }
            }
        }

    }


}
