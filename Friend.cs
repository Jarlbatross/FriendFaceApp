
namespace ConsoleApp9;

internal class Friend
{

    public static void PrintFriendInfo(User user)
    {
        if (User.Friends != null)
            foreach (var friend in User.Friends)
            {
                Console.WriteLine("Navn: " + friend.Name);
                Console.WriteLine("Alder: " + friend.Age);
            }
        else
        {
            Console.WriteLine("Du har ingen venner");
        }
    }


    public void AddFriend(List <User> user)
    {
        Console.WriteLine("Hvilken person vil du legge til som venn?");
        int userInput = Convert.ToInt32(Console.ReadLine());
        User.Friends?.Add(user);
    }

    public void RemoveFriend() { }
}