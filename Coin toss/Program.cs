using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
