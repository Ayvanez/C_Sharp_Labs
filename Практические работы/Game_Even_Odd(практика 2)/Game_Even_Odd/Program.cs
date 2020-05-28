using System;

namespace Game_Even_Odd
{
    class Program
    {
        private static void Play(ref int account)
        {
            Console.WriteLine("Выберете число, на которое хоите поставить");
            Console.WriteLine("Введите '0', если хотите поставить на чётное");
            Console.WriteLine("Введите '1', если хотите поставить на нечётное");
            int parity = int.Parse(Console.ReadLine());
            Console.WriteLine("Какую ставку вы хотите сделать?");
            int bet = int.Parse(Console.ReadLine());
            if (bet > account)
            {
                Console.WriteLine("Введённая ставка превышает ваш баланс = {0}", account);
                return;
            }
            string temp = null;
            if (parity == 0)
            {
                temp = "чётное";
            }
            else if (parity == 1)
            {
                temp = "нечётное";
            }
            Console.WriteLine("Вы уверены что хотите поставить {0} рублей на то что выпадет {1} число?\n Да - 0/ Нет - 1", bet, temp);
            int acception = int.Parse(Console.ReadLine());
            if (acception == 1)
            {
                Play(ref account);
                return;
            }
            else if (acception == 0)
            {
                Random rnd = new Random();
                int value = rnd.Next(1, 64);
                int compare = value % 2;
                Console.WriteLine("Выпало число {0}", value);
                if (parity == compare)
                {
                    Console.WriteLine("Поздравляем! Вы угадали!");
                    account += bet;
                    Console.WriteLine("Теперь на вашем счету {0} рублей", account);
                }
                else
                {
                    Console.WriteLine("К сожалению, вы не угадали");
                    account -= bet;
                    Console.WriteLine("Теперь на вашем счету {0} рублей", account);
                }
            }
        }
        private static void ShowAccount(int account)
        {
            Console.WriteLine("Ваш текущий баланс: {0}", account);
        }
        private static void AddAccount(ref int account)
        {
            Console.WriteLine("Введите сумму, которую хотите внести");
            int add = int.Parse(Console.ReadLine());
            account += add;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в игру \"Угадай Чёт/Нечёт\"");
            Console.WriteLine("Пожалуйста, пополните ваш баланс");
            int account = int.Parse(Console.ReadLine());
            while (true)
            {
                Console.WriteLine("Введите '1', для запуска игры");
                Console.WriteLine("Введите '2', для отображения текущего баланса");
                Console.WriteLine("Введите '3', для пополнения счёта");
                Console.WriteLine("Введите '4', для вывода средств со счёта и выхода из игры");
                char choice = Char.Parse(Console.ReadLine());
                switch (choice)
                {
                    case '1':
                        Play(ref account);
                        break;
                    case '2':
                        ShowAccount(account);
                        break;
                    case '3':
                        AddAccount(ref account);
                        break;
                    case '4':
                        Console.WriteLine("Игра окончена!");
                        Console.WriteLine("Ваш финальный баланс: {0}", account);
                        account = 0;
                        return;
                }
            }
        }

    }
}
