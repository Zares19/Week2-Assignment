using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Garrett Hatcher
//Professor Brandon Olive
//GAME-1343 2001 1 Game and Simulation Programming I
//Januuary 29, 2022

namespace myValue_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
        //Seting myValue
            int myValue = 7;
        
        //Putting myValue into diffrent equations

            Console.WriteLine(-1 + 4 * myValue);

            Console.WriteLine((35 + 5) % myValue);

            Console.WriteLine(14 + -4 * 6 / 12);

            Console.WriteLine(2 + 12 / 6 * 1 - myValue % 2);

        //Using an if statement to figure out if myValue is > or < 4
            if (myValue * myValue < 10)
            {
                Console.WriteLine("myValue is less than 4");
            }
            else
            {
                Console.WriteLine("myValue is greater than 4");
            }
        }
    }
}
