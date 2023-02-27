using System;

namespace zeca_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            //calclar nota 

            int nota1 = 0;
            int nota2 = 0;
            int resultado = 0;

            Console.WriteLine("primera nota:");
            nota1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("segunda nota:");
            nota2 = Convert.ToInt32(Console.ReadLine());

            resultado = (nota1 + nota2) / 2;

            if (resultado >= 5){
                Console.WriteLine($"Foi aprovado seu filha da puta, sai desse pc");
                Console.ReadLine();
            }
            else{
                Console.WriteLine($"você é burro e a culpa é minha?");
            }
        
        }
    }
}
