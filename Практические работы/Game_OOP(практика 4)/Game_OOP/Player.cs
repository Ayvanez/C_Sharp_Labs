using System;

namespace Game_OOP
{
    class Player
    {
        private int account;
        private char choice;
        private int parity;
        private int bet;
        public void SetAccount (int account)
        {
            this.account = account;
        }
        public int GetAccount()
        {
            return this.account;
        }
        public int GetParity()
        {
            return this.parity;
        }
        public int GetBet()
        {
            return this.bet;
        }
        public void MakeChoice(Game game)
        {
            while(choice != 4)
            { 
                Console.WriteLine("Введите '1', для запуска игры");
                Console.WriteLine("Введите '2', для отображения текущего баланса");
                Console.WriteLine("Введите '3', для пополнения счёта");
                Console.WriteLine("Введите '4', для вывода средств со счёта и выхода из игры");
                choice = Char.Parse(Console.ReadLine());
                switch (choice)
                {
                    case '1':
                        game.Play();
                        break;
                    case '2':
                        game.ShowAccount();
                        break;
                    case '3':
                        game.AddAccount();
                        break;
                    case '4':
                        Console.WriteLine("Игра окончена!");
                        Console.WriteLine("Ваш финальный баланс: {0}", account);
                        account = 0;
                        return;
                }
            }
        }
        public void Setparity()
        {
            Console.WriteLine("Выберете число, на которое хотите поставить");
            Console.WriteLine("Введите '0', если хотите поставить на чётное");
            Console.WriteLine("Введите '1', если хотите поставить на нечётное");
            parity = int.Parse(Console.ReadLine());
        }
        public int Setbet(Game game)
        {
            Console.WriteLine("Какую ставку вы хотите сделать?");
            bet = int.Parse(Console.ReadLine());
            if (bet > account)
            {
                Console.WriteLine("Введённая ставка превышает ваш баланс = {0}", account);
                return 0;
            }
            else return 1;
        }
        public void Acception(Game game)
        {
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
                game.Play();
                return;
            }
            else if (acception == 0)
            {
                game.Roll();
            }
        }
    }
}
