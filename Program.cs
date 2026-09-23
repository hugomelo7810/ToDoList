using ToDoList;
Console.WriteLine("Welcome to the ToDo List!");
int option = 0;
List<TodoTask> tasks = new List<TodoTask>();

while (option != 6)
{
    Console.WriteLine("1. Create task");
    Console.WriteLine("2. List tasks");
    Console.WriteLine("3. Delete task");
    Console.WriteLine("4. Complete or reopen task");
    Console.WriteLine("5. Rename task");
    Console.WriteLine("6. Exit");
    Console.Write("Choose an option:");
    option = int.TryParse(Console.ReadLine(), out option) ? option : 0;

    void CreateTask()
    {
        Console.WriteLine("Write a task:");
        string task = Console.ReadLine();
        tasks.Add(new TodoTask { Title = task, IsCompleted = false });
        Console.WriteLine($"Task created: {task}");
        Console.ReadKey();
        Console.Clear();
    }

    void ListTasks()
    {
        if (tasks.Count <= 0)
        {
            Console.WriteLine("No tasks to display.");
        }
        else
        {
            Console.WriteLine("Tasks:");
            for (int i = 0; i < tasks.Count; i++)
            {
                string status = tasks[i].IsCompleted ? "[X]" : "[ ]";
                Console.WriteLine($"{i + 1}. {status} {tasks[i].Title}");
            }
        }
        Console.ReadKey();
        Console.Clear();
    }

    void CompleteTask()
    {
        if (tasks.Count <= 0)
        {
            Console.WriteLine("No tasks to complete.");
        }
        else
        {
            Console.WriteLine("Task:");
            for (int i = 0; i < tasks.Count; i++)
            {
                string status = tasks[i].IsCompleted ? "[X]" : "[ ]";
                Console.WriteLine($"{i + 1}. {status} {tasks[i].Title}");
            }
            Console.Write("Choose a task to complete: ");
            int completedTaskIndex = int.TryParse(Console.ReadLine(), out completedTaskIndex) ? completedTaskIndex : 0;
            if (completedTaskIndex <= tasks.Count && completedTaskIndex > 0)
            {
                tasks[completedTaskIndex -1].IsCompleted = !tasks[completedTaskIndex - 1].IsCompleted;
                Console.WriteLine($"Task updated: {tasks[completedTaskIndex - 1].Title}");
            }
            else
            {
                Console.WriteLine("Invalid task index.");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }

    void DeleteTask()
    {
        if (tasks.Count <= 0)
        {
            Console.WriteLine("No tasks to delete.");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine("Tasks:");
            for (int i = 0; i < tasks.Count; i++)
            {
                string status = tasks[i].IsCompleted ? "[X]" : "[ ]";
                Console.WriteLine($"{i + 1}. {status} {tasks[i].Title}");
            }
            Console.Write("Choose a task to delete:");
            int taskIndex = int.TryParse(Console.ReadLine(), out taskIndex) ? taskIndex : 0;
            if (taskIndex >= 1 && taskIndex <= tasks.Count)
            {
                tasks.RemoveAt(taskIndex - 1);
                Console.WriteLine("Task deleted.");
            }
            else
            {
                Console.WriteLine("Invalid task index.");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }

    switch (option)
    {
        case 1:
            CreateTask();
            break;
        case 2:
            ListTasks();
            break;
        case 3:
            DeleteTask();
            break;
        case 4:
            CompleteTask();
            break;
        case 6:
            Console.WriteLine("Exiting...");
            Thread.Sleep(3000);
            break;
        default:
            Console.WriteLine("Invalid option.");
            Console.ReadKey();
            Console.Clear();
            break;
    }
}