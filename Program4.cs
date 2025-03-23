using System;
using System.Collections.Generic;

class HotPotatoGame
{
    static void Main()
    {
        
        Console.Write("Oyuncu isimlerini virgülle ayırarak girin: ");
        string[] players = Console.ReadLine().Split(',');
        
        Queue<string> queue = new Queue<string>(players);

        Console.Write("kaçıncı sırada elenen olacak?");
        int passCount = int.Parse(Console.ReadLine());

        while (queue.Count > 1)
        {
            for (int i = 0; i < passCount; i++)
            {
                string player = queue.Dequeue();//ilk giren ilk çıkar ilk gireni çıkar, sıranın başına geçir
                queue.Enqueue(player);
            }
            
            string loser = queue.Dequeue();
            Console.WriteLine($"{loser}  kişisi elendi!");
        }

        Console.WriteLine($"Kazanan: {queue.Peek()}");
    }
}