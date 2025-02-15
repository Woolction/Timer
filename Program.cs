using System;
using System.ComponentModel.Design;
using System.Threading;
using System.Threading.Channels;

namespace Timer
{
    internal class Program
    {
        static int? _count = null;
        static int _timers = 0;
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;   
            
            string _click = "";
            bool True = true;

            Console.WriteLine("=============================");
            Console.WriteLine("----------- Timer -----------");
            Console.WriteLine("=============================");

            Console.WriteLine();

            Console.WriteLine("To select Second. Click 'S'");
            
            Console.WriteLine();
            
            while (True)
            {
                try
                {
                    _click = Console.ReadLine(); _click = _click.ToUpper();
                }
                catch(FormatException) 
                {
                    _click = null;
                    Console.WriteLine("To select Second. Click 'S'!");
                }

                if (_click == null) { True = true; }
                else { True = false; }

                if (_click != "S") 
                {
                    True = true;
                    
                    Console.WriteLine(); 
                    Console.WriteLine("To select Second. Click 'S'!");
                    Console.WriteLine();
                }
            }       
            
            if (_click == "S")
            {
                True = true;
                Console.WriteLine();

                Console.Write("How many seconds do you want to set: ");
               
                while (True)
                {
                    try
                    {
                        _count = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        _count = null;

                        Console.WriteLine();
                       
                        Console.Write("How many !seconds! do you want to set: ");
                    }
                    
                    if (_count == null) { True = true; }
                    else { True = false; }
                }
                
                Console.WriteLine();

                Console.WriteLine(_count);
                Console.WriteLine();
               
                CountSecond();
            }  
        }
        private static void CountSecond()
        {
            for (int i = 0; i < _count; i++)
            {
                Thread.Sleep(1000);
                _timers += 1;  //or _timers++;
                Console.WriteLine(_timers);
            }
        }
    }
}
