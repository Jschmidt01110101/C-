
//James Schmidt
//11/22/23

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        TaskManager taskManager = new TaskManager();
        taskManager.AddTask(1, "Complete project", DateTime.Now.AddDays(7), 2);
        taskManager.AddTask(2, "Submit report", DateTime.Now.AddDays(5), 1);

        List<Task> allTasks = taskManager.GetAllTasks();
        Console.WriteLine("All tasks:");
        foreach (Task task in allTasks)
        {
            Console.WriteLine($"Task ID: {task.TaskID}, Description: {task.TaskDescription}, Due Date: {task.DueDate}, Priority: {task.Priority}, Completed: {task.CompletionStatus}");
        }
    }
}