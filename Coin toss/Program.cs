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
                Console.WriteLine("---------- Coin toss ----------");
                coinToss.Input();
                if (coinToss.Exit())
                {
                    break;
                }
                coinToss.Toss();
                coinToss.Result();
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
