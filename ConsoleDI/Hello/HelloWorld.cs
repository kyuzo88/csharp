namespace ConsoleDI.Hello;

public interface IHelloWorld
{
    public Task Greetings();
}

public class HelloWorld : IHelloWorld
{
    public async Task Greetings()
    {
        await Task.Delay(10 *1000);
        Console.WriteLine("Hello world");
    }
}