using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Program2
{
    static string filePath = "tasks.json";
    static List<TaskItem> tasks = new List<TaskItem>();

    static void Main()
    {
        LoadTasks();
        while (true)
        {
            Console.Clear();
            Console.WriteLine("TO DO LIST");
            Console.WriteLine("1. Görev Ekle");
            Console.WriteLine("2. Görevleri Listele");
            Console.WriteLine("3. Görevi Tamamlandı Olarak İşaretle");
            Console.WriteLine("4. Görev Sil");
            Console.WriteLine("5. Çıkış");
            Console.Write("Seçiminiz: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1": AddTask(); break;
                case "2": ListTasks(); break;
                case "3": CompleteTask(); break;
                case "4": DeleteTask(); break;
                case "5": return;
                default: Console.WriteLine("Geçersiz seçim!!!!"); break;
            }
        }
    }

    static void AddTask()
    {
        Console.Write("Yeni Görev Girin: ");
        string description = Console.ReadLine();
        
        tasks.Add(new TaskItem { Description = description, IsCompleted = false });
        SaveTasks();
    }

    static void ListTasks()
    {
        Console.WriteLine("\nGörevler:");
        for (int i = 0; i < tasks.Count; i++)
        {
            string status = tasks[i].IsCompleted ? "[T]" : "[ ]";
            Console.WriteLine($"{i + 1}. {status} {tasks[i].Description}");
        }
        
        Console.ReadLine();
    }

    static void CompleteTask()
    {
        ListTasks();
        Console.Write("Tamamlanan görev numarası: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= tasks.Count)//stringden inte
        {
            tasks[index - 1].IsCompleted = true;
            SaveTasks();
        }
    }

    static void DeleteTask()
    {
        ListTasks();
        Console.Write("Silinecek görev numarası: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= tasks.Count)
        {
            tasks.RemoveAt(index - 1);
            SaveTasks();
        }
    }

    static void SaveTasks()
    {
        File.WriteAllText(filePath, JsonSerializer.Serialize(tasks));//jsonda sakladık
    }

    static void LoadTasks()
    {
        if (File.Exists(filePath))
        {
            string content = File.ReadAllText(filePath);
            tasks = JsonSerializer.Deserialize<List<TaskItem>>(content) ?? new List<TaskItem>();
        }
    }
}

class TaskItem
{
    public string Description { get; set; }
    public bool IsCompleted { get; set; }
}