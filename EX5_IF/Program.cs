Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "иван")
{
    Console.WriteLine("Какой приятный человек!");
}
else
{
    Console.WriteLine("Привет " + username);
}