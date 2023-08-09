// Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");
Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();


// Console.OutputEncoding = System.Text.Encoding.UTF8;

if (username.ToLower() == "Маша")
{
    Console.WriteLine("Ура, это же МАША !");
}
else
{
    Console.Write("Привет, " + username +"!");
}