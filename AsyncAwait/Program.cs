// See https://aka.ms/new-console-template for more information

Console.WriteLine("Application started");

var hello1 = WriteHelloAsync(1, 5);
var hello2 = WriteHelloAsync(2, 3);
var hello3 = WriteHelloAsync(3, 8);

await Task.WhenAll(hello1, hello2, hello3);

Console.WriteLine("Application finished");

async Task WriteHelloAsync(int callOrder , int seconds)
{
    await Task.Delay(seconds *1000);
    Console.WriteLine($"run {callOrder}:{seconds} seconds waited");
}