using System;

namespace Project
{
    class Program
    {
        static void Main(String[] args)
        {

            //Cabeçalho
            Console.WriteLine("Digite 3 números: "); 

            //valores de entrada
            Console.WriteLine("número 1: "); 
            var p1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("número 2: ");
            var p2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("número 3: ");
            var p3 = Convert.ToInt32(Console.ReadLine());

            //Extansiando um novo objeto
            Calculos obj = new Calculos();

            //Declarando as variáveis
            float Rst = obj.Media (p1, p2, p3);
            int RstMin = obj.Min(p1, p2, p3);
            int RstMax = obj.Max(p1, p2, p3);
            

            //resultados
            Console.WriteLine("Média: " + Rst);
            Console.WriteLine("Min: " + RstMin);
            Console.WriteLine("Max: " + RstMax);


            


            












        }
    }
}


