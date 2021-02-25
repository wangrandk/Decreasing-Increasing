using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Author: Ran Wang/ s111503 
Dato: 23.02.21
Formål: opgave Dag03  04
skrivelse: D
Test: 

*/
namespace Counting
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("enter a number: ");
            int i =Int32.Parse( Console.ReadLine());
            int l = i;
            int res; // out param in method allows variable that does not have a value.

            Console.WriteLine("choose decreasing or increasing");
            string operators = Console.ReadLine();

            switch (operators)
            {
                case "+":
                    Console.WriteLine("Du valgte +");
                    break;
                case "-":
                    Console.WriteLine("Du valgte -");
                    break;           
                default:
                    Console.WriteLine("Du har valgte en ulovlig tegn, vælge en operatør melle +,-");
                    break;
            }


            Console.WriteLine("Before called {0}", i);
            if (operators == "+")
            {
                Increasing(ref i);
                Console.WriteLine("IN MAIN After called {0}", i);
            }
            else if (operators == "-")
            {
                Decreasing(ref i);
                Console.WriteLine("IN MAIN After called {0}", i);
            }

            Console.WriteLine("do you want to reset the number to {0}? press Y or N" , l );

            string Bi = (Console.ReadLine()).ToLower();
            switch (Bi)
            {
                case "y":
                    Console.WriteLine("Du valgte Yes");
                    break;
                case "n":
                    Console.WriteLine("Du valgte No");
                    break;
                default:
                    Console.WriteLine("Du har valgte en ulovlig tegn, vælge en operatør melle Y,N");
                    break;
            }

            if (Bi == "y")
            {
                //ResetNumber(i,l);
                Console.WriteLine("After reset {0}", ResetNumber(i, l));

                OutResetNumber(l, out res); //perameter modifier "out"
                Console.WriteLine("Out After reset {0}", res);
                ParamsOutputNumber(i, l, res);
            }
            else
            {
                Console.WriteLine("After called {0}", i);
            }
            Console.ReadLine();
        }

        //Parametret afleveres som reference –værdien sættes fra hvor metoden kaldes –men metoden er tilladt at arbejde videre på denne variabe
        public static void Increasing(ref int a) //perameter modifier "ref"
        {
            a++;
            //Console.WriteLine("After called {0}", a);
        }
        public static void Decreasing(ref int a) //perameter modifier "ref"
        {
            a--;
        }

        //indikerer at der er tale om retningen ind ( til metoden). Parameteret afleveres som værdi –der foretages en egen kopi i metoden, der arbejdes videre p
        public static int ResetNumber(int a, int b)
        {
            //Console.WriteLine("After reset : {0}", a);
            return b;
        }
        public static void OutResetNumber(int a, out int b) //perameter modifier "out", can return more values.
        {
            //Console.WriteLine("After reset : {0}", a);
            b = a;
        }
        // En metoden kan kun have et parameter med modifikatoren params og det skal samtidig være det sidste argument til metoden
        public static void ParamsOutputNumber(int a, params int[] list) //perameter modifier "out", can return more values.
        {
            //Console.WriteLine("After reset : {0}", a);
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine("first arg {0}, using params in method to output a list : {1} = {2}",a, i, list[i]);
            }
        }
    }
}
