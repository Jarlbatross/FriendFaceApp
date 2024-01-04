namespace ConsoleApp9;

internal class User
{
    public string Name { get; }
    public string Password { get; }
    public int Age { get; }
    public string Birthday { get; }
    public bool IsLoggedIn { get; private set; }
    public static List<User>? Friends { get; set; }

    public User(string name, string password, int age, string birthday, bool isLoggedIn)
    {
        Name = name;
        Password = password;
        Age = age;
        Birthday = birthday;
        IsLoggedIn = isLoggedIn;
        Friends = new List<User>();
    }

    public void PrintUserInfo()
    {
        Console.Clear();
        Console.WriteLine(Name);
        Console.WriteLine(Password);
        Console.WriteLine(Age);
        Console.WriteLine(Birthday);
        Console.WriteLine("\n");
    }

    public void DisplayUsers(List<User> users)
    {
        int i = 1;
        foreach (var user in users)
        {
            Console.WriteLine($"{i}. {user.Name}\n");
            i++;
        }
    }

    public void DisplayFriends()
    {
        foreach (var user in Friends)
        {
            Console.WriteLine("***********************");
            Friend.PrintFriendInfo(user);
            Console.WriteLine("***********************");
        }
    }

    public bool LogIn(string userName, string userPassword)
    {

        if (userName == Name && userPassword == Password)
        {
            IsLoggedIn = true;
            return true;
        }
        else
        {
            return false;
        }
    }
}