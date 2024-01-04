using System.Collections.Generic;

namespace ConsoleApp9;

internal class FriendFace
{
    public static void userMenu(User loggedInUser, List<User> users)
    {
        Console.Clear();
        Console.WriteLine("Hva vil du gjøre?");
        Console.WriteLine("(1) Se profilen min");
        Console.WriteLine("(2) Se vennelisten min");
        Console.WriteLine("(3) Legg til en venn");
        Console.WriteLine("(4) Fjern en venn");
        Console.WriteLine("(5) Logg ut");
        var userInput = Convert.ToInt32(Console.ReadLine());

        if (userInput == 1) loggedInUser.PrintUserInfo();
        else if (userInput == 2) loggedInUser.DisplayFriends();
        else if (userInput == 3) 
        { 
            loggedInUser.DisplayUsers(users);
            Friend.AddFriend();
            
        }
        else userMenu(loggedInUser, users);
    }
}