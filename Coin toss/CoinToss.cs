using System;

namespace Coin_toss
{
    class CoinToss
    {
        enum Option { Unknow = 0, Eagle, Obverse };
        Option ChosedOption = Option.Unknow;
        Option DrawedOption = Option.Unknow;
        Random random = new Random();
        bool exit = false;
        public void Input()
        {
            bool complete = false;
            while (!complete)
            {
                Console.WriteLine("> Eagle or Obverse?");
                Console.WriteLine("> 1. Eagle");
                Console.WriteLine("> 2. Obverse");
                Console.WriteLine("> Other to exit");

                var mode = Console.ReadLine();

                if (int.TryParse(mode, out int number))
                {
                    try
                    {
                        ChosedOption = (Option)number;
                        complete = true;
                    }
                    catch
                    {
                        Console.WriteLine($"> The \"{number}\" in not an option!");
                    }
                }
                if (ChosedOption == Option.Unknow || GetOptionAsString(ChosedOption) == String.Empty)
                {
                    exit = true;
                }
            }
        }
        public void Toss() { DrawedOption = (Option)random.Next(1, 3); }
        public void Result()
        {
            Console.WriteLine($"> Drawed {GetOptionAsString(DrawedOption)}");
            if(DrawedOption == ChosedOption)
            {
                Console.WriteLine($"> GJ you WIN (Your option was \"{GetOptionAsString(ChosedOption)}\")");
            }
            if (DrawedOption != ChosedOption)
            {
                Console.WriteLine($"> ;( you LOSE (Your option was \"{GetOptionAsString(ChosedOption)}\")");
            }
        }
        public bool Exit()
        {
            if (exit)
            {
                return true;
            }
            return false;
        }
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
            }
            return String.Empty;
        }
    }
}
