Console.Write("Enter your username: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("Yahoo, it's Masha!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}