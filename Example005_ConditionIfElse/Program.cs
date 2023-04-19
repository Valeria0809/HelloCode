Console.Write ("Введите ваше имя: ");
string username = Console.ReadLine();

if (username.ToLower() == "иван")
{
    Console.WriteLine ("Ура, это же ИВАН!");
}
else
{
    Console.Write ("Привет, ");
    Console.WriteLine (username);
}