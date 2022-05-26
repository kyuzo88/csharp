namespace AsyncAwaitNested;

public static class Level1
{
    public static async Task RunLvl1()
    {
        Console.WriteLine($"Hello From Lvl 1");
        await Task.Delay(5 *1000);
        await Level2.RunLvl2();
        Console.WriteLine($"Bye From Lvl 1");
    }
}