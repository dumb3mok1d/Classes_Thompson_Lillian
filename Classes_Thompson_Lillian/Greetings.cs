using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Thompson_Lillian
{
    class Greetings
    {   
        /// <summary>
        /// 
        /// </summary>

        public void Welcome()
        {
            Console.WriteLine("Hello Traveler, welcome!");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public void Hello(string name)
        {
            Console.WriteLine($"{name}, thank you for joining us today! :)");
        }
    }
}
