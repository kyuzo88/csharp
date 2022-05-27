namespace ConsoleDI.Hello;

public interface IHelloUniverse
{
    public Task Greetings();
}

public class HelloUniverse : IHelloUniverse
{
    public async Task Greetings()
    {
        await Task.Delay(5 *1000);
        Console.WriteLine("Hello universe");
    }
}