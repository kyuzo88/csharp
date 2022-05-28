// See https://aka.ms/new-console-template for more information

using ConsoleDI;
using ConsoleDI.File;
using ConsoleDI.Hello;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Text.RegularExpressions;

// Scoped
// Singleton
// Transient

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
        services
            .AddTransient<IHelloWorld, HelloWorld>()
            .AddTransient<IHelloUniverse, HelloUniverse>()
            .AddTransient<IFileService, FileService>())
    .Build();

using IServiceScope serviceScope = host.Services.CreateScope();
var provider = serviceScope.ServiceProvider;

// hello
var helloWorld = provider.GetRequiredService<IHelloWorld>();
var helloUniverse = provider.GetRequiredService<IHelloUniverse>();

await helloWorld.Greetings();
await helloUniverse.Greetings();

// files
var fileService = provider.GetRequiredService<IFileService>();
var files = await fileService.GetFilesFromDirectory("/home/andi/TestFolder");
Console.WriteLine($"file count: {files.Count}");
var file = files.First();

// regex
var searchString = "huhu";
var regex = new ThreadLocal<Regex>(() =>
    new Regex(searchString, RegexOptions.IgnoreCase));

var matches = File.ReadLines(file)
    .Zip(Enumerable.Range(1, Int32.MaxValue), (s, i) => new {
        Num = i,
        Text = s,
        File = file
    }).Where(x => regex.Value.IsMatch(x.Text));

foreach (var line in matches)
{
    Console.WriteLine($"{line.File}:{line.Num} {line.Text}");
}

Console.ReadLine();
await host.RunAsync();