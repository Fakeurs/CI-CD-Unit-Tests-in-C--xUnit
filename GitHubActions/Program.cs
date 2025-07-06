namespace GitHubActions;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Add(2,3));
    }

    public static int Add(int x, int y)
    {
        return x + y;
    }
}