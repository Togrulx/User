

using User.Authhentication;

Console.WriteLine("1. Register");
Console.WriteLine("2. Login");

string Request = Console.ReadLine();

while (Request!="0")
{
    switch (Request)
    {
        case "1":
            Authhentication.Register();
                break;
        default:
            Console.WriteLine("Select valid option");
            break;
    }
}
