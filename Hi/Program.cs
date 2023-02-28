Console.Write("Ведите, пожалуйста имя: - ");
string username = Console.ReadLine();

if (username.ToLower() == "таня")
{
    Console.WriteLine("О! Какие лююююди))). Привет, Танюшка!");
}
else
{
    Console.Write("А, это ты. Ну, привет ");
    Console.WriteLine(username);
}