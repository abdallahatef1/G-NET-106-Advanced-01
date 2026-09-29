using System;
using System.Collections.Generic;
using System.Text;

namespace advanced1
{
    internal class Dog :Animal , IPet
    {
        public override string Speak() { return "Woof"; }

       
        public void play()
        {
            Console.WriteLine("Dog is playing");
        }
    }
}
