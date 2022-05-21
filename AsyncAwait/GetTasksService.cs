namespace AsyncAwait;

public static  class GetTasksService
{
    public static List<Task> GetTasks()
    {
        return new List<Task>()
        {
            WriteAsyncService.WriteAsync(1, 5),
            WriteAsyncService.WriteAsync(2, 3),
            WriteAsyncService.WriteAsync(3, 8)
        };
    }
}