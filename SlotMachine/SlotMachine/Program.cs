using System;
using System.IO;
using System.Threading;

namespace Slot_Machine
{
    class Player
    {
        public long Balance;
        public long Bet;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Slot-Machine";
            int count(int[] m,int x)
            {
                int n = 0;
                for (int i = 0; i < m.Length; i++)
                {
                    if (m[i] == x)
                    {
                        n++;
                    }
                }
                return n;
            }
            for (; ; )
            {
                Console.Clear();
                bool win = false;
                int[] Machine = new int[3];
                Player player = new Player();
                player.Balance = long.Parse(File.ReadAllText("Balance"));
                Console.WriteLine("\n - - 1 (1:1)");
                Console.WriteLine(" - 1 1 (5:1)");
                Console.WriteLine(" 1 1 1 (500:1)");
                Console.WriteLine(" 2 2 2 (25:1)");
                Console.WriteLine(" 3 3 3 (50:1)");
                Console.WriteLine(" 4 4 4 (75:1)");
                Console.WriteLine(" 5 5 5 (100:1)");
                Console.WriteLine(" 6 6 6 (250:1)");
                Console.WriteLine(" 7 7 7 (1000:1)\n");
                Console.WriteLine($"Ваш баланс {player.Balance}$\n");
                Console.WriteLine("Ваши ставки!\n");
                Console.Write("Ставка: ");
                player.Bet = long.Parse(Console.ReadLine());
                Console.Clear();
                Random random = new Random();
                for (int i = 0; i < Machine.Length; i++)
                {
                    
                    Machine[i] = random.Next(1,7);
                }
                Console.Write("-");
                foreach (var s in Machine)
                {
                    Console.Write(s+" ");
                }
                Console.Write("-");
                Console.WriteLine("\n");
                if (count(Machine,1)==1)
                {
                    win = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Вы Выиграли {player.Bet*2}!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    player.Balance += player.Bet * 2;
                }
                if (count(Machine, 1) == 2)
                {
                    win = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Вы Выиграли {player.Bet * 5}!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    player.Balance += player.Bet * 5;
                }
                if (count(Machine, 1) == 3)
                {
                    win = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Вы Выиграли {player.Bet * 500}!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    player.Balance += player.Bet * 500;
                }
                if (count(Machine, 2) == 3)
                {
                    win = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Вы Выиграли {player.Bet * 25}!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    player.Balance += player.Bet * 25;
                }
                if (count(Machine, 3) == 3)
                {
                    win = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Вы Выиграли {player.Bet * 50}!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    player.Balance += player.Bet * 50;
                }
                if (count(Machine, 4) == 3)
                {
                    win = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Вы Выиграли {player.Bet * 75}!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    player.Balance += player.Bet * 75;
                }
                if (count(Machine, 5) == 3)
                {
                    win = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Вы Выиграли {player.Bet * 100}!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    player.Balance += player.Bet * 100;
                }
                if (count(Machine, 6) == 3)
                {
                    win = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Вы Выиграли {player.Bet * 250}!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    player.Balance += player.Bet * 250;
                }
                if (count(Machine, 7) == 3)
                {
                    win = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Вы Выиграли {player.Bet * 1000}!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    player.Balance += player.Bet * 1000;
                }
                if(!win)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Вы Проиграли!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    player.Balance -= player.Bet;
                }
                File.WriteAllText("Balance",player.Balance.ToString());
                Console.ReadLine();
            }
        }
    }
}
