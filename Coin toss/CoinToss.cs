using System;

namespace Coin_toss
{
    class CoinToss
    {
        enum Option { Unknow = 0, Eagle, Obverse, Stats };
        Option ChosedOption = Option.Unknow;
        Option DrawedOption = Option.Unknow;

        Random random = new Random();

        float wins = 0f;
        float lost = 0f;

        bool exit = false;

        public void WelcomeText()
        {
            Console.Clear();
            Console.WriteLine("---------- Coin toss ----------");
            Console.WriteLine("> Eagle or Obverse?");
            Console.WriteLine("> 1. Eagle");
            Console.WriteLine("> 2. Obverse");
            Console.WriteLine("> 3. Statistics");
            Console.WriteLine("> Other to exit");
        }
        public void Input()
        {
            bool complete = false;
            while (!complete)
            {
                Console.Write("> ");
                var input = Console.ReadLine();
                if (int.TryParse(input, out int number1))
                {
                    ChosedOption = (Option)number1;
                    complete = true;
                }
                else
                    Console.WriteLine($"> Seriosly?! \"{input}\" is not a number!");

                if (ChosedOption == Option.Unknow || GetOptionAsString(ChosedOption) == String.Empty)
                    exit = true;
            }
        }
        public void Toss() { DrawedOption = (Option)random.Next(1, 3); }
        public void Result()
        {
            if (ChosedOption == Option.Stats)
            {
                Statistic();
                return;
            }
            Console.WriteLine($"> Drawed {GetOptionAsString(DrawedOption)}");
            if (DrawedOption == ChosedOption)
            {
                Console.WriteLine($"> GJ you WIN (Your option was \"{GetOptionAsString(ChosedOption)}\")");
                wins++;
            }

            if (DrawedOption != ChosedOption)
            {
                Console.WriteLine($"> ;( you LOSE (Your option was \"{GetOptionAsString(ChosedOption)}\")");
                lost++;
            }
        }
        public bool Exit()
        {
            if (exit)
                return true;
            return false;
        }

        private void Statistic()
        {
            Console.WriteLine($"Wins: {wins}");
            Console.WriteLine($"Lost: {lost}");
            Console.WriteLine($"Win Ratio: {WinRatio()}%");
        }
        private float WinRatio() { return wins/(wins + lost) * 100; }
        private String GetOptionAsString(Option option)
        {
            switch (option)
            {
                case Option.Unknow:
                    return "Unknow";
                case Option.Eagle:
                    return "Eagle";
                case Option.Obverse:
                    return "Obverse";
                case Option.Stats:
                    return "Stats";
            }
            return String.Empty;
        }
    }
}
