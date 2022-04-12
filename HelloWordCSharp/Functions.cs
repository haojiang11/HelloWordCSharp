namespace HelloWordCSharp;

public class Tests { 
    
    // ?? operator
    public static T SafeTo<T>(T val, T backupVal)
    {
        return (val ?? backupVal);
    }

    
    // tuple pattern, discard pattern
    public static string RockPaperScissors(string first, string second)
    => (first.ToLower(), second.ToLower()) switch
    {
        ("rock", "paper") => "rock is covered by paper. Paper wins.",
        ("rock", "scissors") => "rock breaks scissors. Rock wins.",
        ("paper", "rock") => "paper covers rock. Paper wins.",
        ("paper", "scissors") => "paper is cut by scissors. Scissors wins.",
        ("scissors", "rock") => "scissors is broken by rock. Rock wins.",
        ("scissors", "paper") => "scissors cuts paper. Scissors wins.",
        (_, _) => "tie"
    };

    // await foreach
    public async static System.Collections.Generic.IAsyncEnumerable<int> GenerateNumbers(int toNumber)
    {
        for (int i = 0; i < toNumber; i++)
        {
            await Task.Delay(100);
            yield return i;
        }
    }

}