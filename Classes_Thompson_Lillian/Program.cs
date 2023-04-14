using System;

namespace Classes_Thompson_Lillian
{
    class Program
    {
        static void Main(string[] args)
        {   
            //
            Greetings greetings = new Greetings(); //
            //
            greetings.Welcome();

            //
            Console.WriteLine("What is your name Dawg?");
            string userName = Console.ReadLine();

            //
            greetings.Hello(userName);
        }
    }
}
