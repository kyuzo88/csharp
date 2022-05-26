// See https://aka.ms/new-console-template for more information

using AsyncAwaitBasic;

Console.WriteLine("Tasks: WhenAll");
var tasksWhenAll = GetTasksService.GetTasks();
await TaskWhenAll.RunAsync(tasksWhenAll);

Console.WriteLine("");

Console.WriteLine("Tasks: WhenAny");
var tasksWhenAny = GetTasksService.GetTasks();
await TaskWhenAny.RunAsync(tasksWhenAny);


Console.WriteLine("Application finished");
