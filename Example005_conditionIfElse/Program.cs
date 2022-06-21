
Console.WriteLine("Введитте имя пользователя");
string userName = Console.ReadLine();

if (userName.ToLower() == "илья")
{
Console.WriteLine("Привет, админ");
}
else
{
Console.Write("Привет, пользователь ");
Console.WriteLine(userName);
}