using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Олимпиада_по_информатике_11_класс_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int A = int.Parse(Console.ReadLine());

            int B = int.Parse(Console.ReadLine());

    */
            /* // Задание 1 олемпиада

                    int A = 1;
                    int B = 8;

                    int N = (B - A) / 4;



                    int time = (B - A) / 2;

                      if (A % 2 == 0 & B % 2 != 0) {

                        time += 1;

                    }

                    //int f = (N / 4) % 2;

                    Console.WriteLine(time);
                    Console.WriteLine();
                    */

            

            int A = 1;
            int B = 2;
            int C = 3;

            int H = Math.Min(A, B);
            int J = Math.Min(B, C);
            int H1 = Math.Min(A, C);
            int f = Math.Max(H, H1);

            int winter = 0;

            for (int i = 0; i <= Math.Max(f, J); i++)
            {

                winter =+ i;

            }
                Console.WriteLine(winter);

            

            /*
            int A = int.Parse(Console.ReadLine());


            int f = A % 5;

            if (f == 0)
            {


                string n1 = A.ToString();


               // string n2 = n1.ToArray[0]

              //  string R = n1[0] - n1 [1];


                


            }
*/
            Console.ReadKey();


    
        }
    }
}
