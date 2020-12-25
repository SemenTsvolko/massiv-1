using System;
using System.Linq;

namespace massiv_1
{
    class Program
    {
        static void Main(string[] args)
        {


            
            {
                Console.WriteLine("Отрицательные числа");
                int[] Semen = new int[] { -7,-6,-5,-4,-3,-2,-1, };

                for (int i = 0; i < Semen.Length; i++)

                {
                    Semen[i] = 1;
                    
                }
                {
                    Console.WriteLine(Semen.Where(i => i % 1 ==0).Sum());

                }
                Console.WriteLine("---------------------------------------------");
                {
                    
                    Console.WriteLine("произведение положительных=");
                    int[] Sam = { 1,2,3,4,5,6,7 };
                     
                    {
                        
                        int r = Sam[0] * Sam[1];
                        int r1 = r * Sam[2];
                        int r2 = r1 * Sam[3];
                        int r3 = r2 * Sam[4];
                        int r4 = r3 * Sam[5];
                        int r5 = r4 * Sam[6];
                        Console.WriteLine(r5);
                    }
                    Console.WriteLine("------------------------------------------------------------------");
                    {
                        int[] Sem = new int[] { -7,-6,-5,-4,-3,-2,-1,0,1,2,3,4,5,6,7 };
                        Console.WriteLine("Количество нулевых элементов = ");
                        Sem[7] = 1;
                        Console.WriteLine(Sem[7]);
                        
                    }
                }  
                Console.ReadLine();
            }
        }
    }
}
