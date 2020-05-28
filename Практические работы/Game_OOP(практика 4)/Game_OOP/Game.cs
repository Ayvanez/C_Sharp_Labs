using System;

namespace Game_OOP
{
    class Game
    {
        private Player player;
        public Game (Player player)
        {
            this.player = player;
        }

        internal Player Player
        {
            get => default;
            set
            {
            }
        }

        public void Greetings()
        {
            Console.WriteLine("Добро пожаловать в игру \"Угадай Чёт/Нечёт\"");
            Console.WriteLine("Пожалуйста, пополните ваш баланс");
            player.SetAccount(int.Parse(Console.ReadLine()));
            player.MakeChoice(this);
        }
        public void Play()
        {
            player.Setparity();
            int valid = player.Setbet(this);
            if (valid == 1)
            {
                player.Acception(this);
            }
        }
        public void ShowAccount()
        {
            Console.WriteLine("Ваш текущий баланс: {0}", player.GetAccount());
        }
        public void AddAccount()
        {
            Console.WriteLine("Введите сумму, которую хотите внести");
            int add = int.Parse(Console.ReadLine());
            player.SetAccount(player.GetAccount() + add);
        }
        public void Roll()
        {
            Random rnd = new Random();
            int value = rnd.Next(1, 64);
            int compare = value % 2;
            Console.WriteLine("Выпало число {0}", value);
            if (player.GetParity() == compare)
            {
                Console.WriteLine("Поздравляем! Вы угадали!");
                player.SetAccount(player.GetAccount() + player.GetBet());
                Console.WriteLine("Теперь на вашем счету {0} рублей", player.GetAccount());
            }
            else
            {
                Console.WriteLine("К сожалению, вы не угадали");
                player.SetAccount(player.GetAccount() - player.GetBet());
                Console.WriteLine("Теперь на вашем счету {0} рублей", player.GetAccount());
            }
        }
    }
}
