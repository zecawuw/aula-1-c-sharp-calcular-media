using System;

namespace zeca_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            //calclar nota 

            double np1 = 0;
            double np2 = 0;
            double pim = 0;
            double calcular;

            Console.WriteLine("primera nota np1:");
            np1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("segunda nota np2:");
            np2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("segunda nota pim:");
            pim = Convert.ToDouble(Console.ReadLine());

            calcular = ((np1 * 0.4) + (np2 * 0.4) + (pim * 0.2));

            if (calcular >= 5){
                Console.WriteLine($"Quer parabens? Só porque comi sua mãe não significa que sou seu pai");
                Console.ReadLine();
            }
            else{
                Console.WriteLine($"você é burro e a culpa é minha?");
            }
        
        }
    }
}
