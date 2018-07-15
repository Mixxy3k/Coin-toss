using System;

namespace Coin_toss
{
    class Program
    {

        static void Main(string[] args)
        {
            CoinToss coinToss = new CoinToss();
            for (; ; )
            {
                coinToss.WelcomeText();
                coinToss.Input();
                if (coinToss.Exit())
                    break;
                coinToss.Toss();
                coinToss.Result();
                Console.ReadKey();
            }
        }
    }
}
