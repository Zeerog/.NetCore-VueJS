using System;

namespace _8.Lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            int bank, bet, dice;
            Random rnd = new Random();
            Console.WriteLine("Добро пожаловать на нашу лотерею.\nПожалуйста, укажите сколько у вас в наличии монет и мы приступим к игре.");
            int.TryParse(Console.ReadLine(), out bank);
            Console.Clear();
            for (; ; )
            {
                Console.Write("Вы можете выйти в любой момент просто поставив 0 монет\n" +
                    "Правила просты, вы делаете ставку, а я бросаю кубик.\n" +
                    "Все решает слепая удача. Вот возможные варианты:\n" +
                    "1-5\tВы теряете ставку\n" +
                    "6-8\tВы получаете ставку обратно\n" +
                    "9-11\tВы получаете удвоенную ставку\n" +
                    "12\tВы получаете десятикратную ставку\n" +
                    "Как вы можете заметить, все очень просто.\n" +
                    $"На данный момент у вас осталось еще {bank} монет.\n" +
                    "Ваша ставка:\t");
                int.TryParse(Console.ReadLine(), out bet);
                if (bet == 0)
                    Environment.Exit(0);
                else if(bet>bank)
                {
                    Console.Write("Сожалею, но у вас не хватает монет");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                    continue;
                }
                dice = rnd.Next(1, 12);
                Console.Write($"На кубике выпало: {dice}.\t");
                switch (dice)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                        Console.WriteLine("К сожалению вы проиграли, повезет в следующий раз.");
                        bank -= bet;
                        break;
                    case 6:
                    case 7:
                    case 8:
                        Console.WriteLine("Вы не выиграли, но и не потеряли ничего");
                        break;
                    case 9:
                    case 10:
                    case 11:
                        Console.WriteLine($"Поздравляю, вы выиграли {bet * 2} монет.");
                        bank += bet;
                        break;
                    case 12:
                        Console.WriteLine($"Невероятно, это джекпот, вы выиграли {bet * 10} монет.");
                        bank += bet*9;
                        break;
                }
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
            }
        }
    }
}
