// See https://aka.ms/new-console-template for more information

using ConsoleApp9;

List<User> users = new List<User>()
{
    new("Jarl", "Passord", 35, "07.05.88", false),
    new("Gjert", "gjert", 42, "06.03.1981", false),
    new("Line", "line", 28, "13.11.1995", false),
    new("Ådne", "ådne", 35, "fødselsdato", false),
    new("Miguel", "miguel", 29, "fødselsdato", false)
};

User loggedInUser = null;

while (loggedInUser == null)
{
    Console.WriteLine("Skriv inn brukernavn og passord:");
    Console.Write("Brukernavn: ");
    var userName = Console.ReadLine();
    Console.Write("Passord: ");
    var userPassword = Console.ReadLine();

    foreach (var user in users)
    {
        if (user.LogIn(userName, userPassword))
        {
            loggedInUser = user;
            Console.Clear();
            FriendFace.userMenu(loggedInUser, users);
            break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Feil brukernavn og/eller passord, prøv på nytt.");
        }
    }

}
