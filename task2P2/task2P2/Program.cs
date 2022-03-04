using System;

namespace task2P2
{
    class Program
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();
            int count = 0;
            char character = 'a'  ;

                foreach (char ch in names)
                {
                    if (ch == character)
                    {
                        count++;
                    }
                    
                }
                Console.WriteLine("Bu mətndə (a) simvolunun sayı:" + count);
            
           
            
        }
       
    }
}
