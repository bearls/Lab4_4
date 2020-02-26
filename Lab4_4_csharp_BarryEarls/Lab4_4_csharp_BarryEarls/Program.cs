using System;

namespace Lab4_4_Csharp_BarryEarls
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] blackListWord = { "buy", "viagra", "XXX", "free money",
            "lifetime offer", "send money", "bank account", "nigeria",
            "online pharmacy", "h8te", "meet girls" };

            bool isSpam = false;
            string message = Console.ReadLine();
            message = message.ToLower();

            for (int i = 0; i < blackListWord.Length; i++)
            {
                if (message.Contains(blackListWord[i]))
                {
                    isSpam = true;
                }
            }


            if (isSpam == true)
            {

                Console.WriteLine("The message contained spam");
            }
            else
            {

                Console.WriteLine("The Message Is Ok.");
            }



        }
    }
}
