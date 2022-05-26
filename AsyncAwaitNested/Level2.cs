namespace AsyncAwaitNested;

public static class Level2
{
    public static async Task RunLvl2()
    {
        Console.WriteLine($"Hello From Lvl 2");
        await Task.Delay(5 *1000);
        Console.WriteLine($"Bye From Lvl 2");
    }
}