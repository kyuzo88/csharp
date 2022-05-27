// See https://aka.ms/new-console-template for more information

using ConsoleDI;
using ConsoleDI.Hello;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

// Scoped
// Singleton
// Transient

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
        services
            .AddTransient<IHelloWorld, HelloWorld>()
            .AddTransient<IHelloUniverse, HelloUniverse>())
    .Build();

using IServiceScope serviceScope = host.Services.CreateScope();
var provider = serviceScope.ServiceProvider;

// hello
var helloWorld = provider.GetRequiredService<IHelloWorld>();
var helloUniverse = provider.GetRequiredService<IHelloUniverse>();

await helloWorld.Greetings();
await helloUniverse.Greetings();

//

Console.WriteLine("huhu");
Console.ReadLine();
await host.RunAsync();