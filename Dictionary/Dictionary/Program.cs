using System.Collections.Generic;
using System;

namespace Dictionary
{
    public class Program
    {
        public static void Main()
        {
            Dictionary<string, int> wallet = new Dictionary<string, int>();

            string card = "Card";
            string cash = "Cash";

            int cardMoney = 50;
            int cashMoney = 10;

            Console.WriteLine($"Added wallets:\n{card} - {cardMoney}$\n{cash} - {cashMoney}$");
            wallet.Add(card, cardMoney);
            wallet.Add(cash, cashMoney);

            Console.WriteLine($"\nLength: {wallet.Count}\n");

            Console.WriteLine($"Check contain key {card}: {wallet.ContainsKey(card)}");

            int checkMoneyCount = 20;
            Console.WriteLine($"Check, is in any wallet {checkMoneyCount}$: {wallet.ContainsValue(checkMoneyCount)}");

            wallet.Clear();
            Console.WriteLine($"\nClear wallets, and current length: {wallet.Count}");
        }
    }
}