using System;

namespace task2P2
{
    class Program
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();
            int count = 0;
            char character = 'a';
            char character1 = 'A';

            foreach (char ch in names)
            {
                if (ch == character || ch == character1)
                {
                    count++;
                   
                }
                else 
                {
                       
                }
                
            }
            Console.WriteLine("Bu mətndə (a,A) simvolunun sayı:" + count);



        }

    }
}
