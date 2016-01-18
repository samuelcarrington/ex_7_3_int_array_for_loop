using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_7_3_int_array_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program, which creates an array of 20 elements 
            of type integer and initializes each of the elements with 
            a value equals to the index of the element multiplied by 5. 
            Print the elements to the console. (Chapter 7, Exercise 1)
            */

            //creates an array of 20 elements of type integer
            int[] multiplied = new int[20];
            //and initializes each of the elements
            for (int i = 0; i < 20; i++)        
            {
                //with a value equals to the index of the element multiplied by 5
                multiplied[i] = i * 5;
                //print the elements to the console           
                Console.Write(multiplied[i] + " "); 
            }
            Console.ReadKey();
        }
    }
}
