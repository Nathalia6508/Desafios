using System;

namespace DesafiosA1
{

    public class Desafio
    {
        public void Desafio01()
        {
            int valor;
            
            int dobro;
            
            int triplo;
            
            double raiz;

            Console.Write("Informe o valor: ");
            valor = Convert.ToInt32(Console.ReadLine());

            dobro = 2 * valor;
            triplo = 3 * valor;
            raiz = Convert.ToDouble(Math.Sqrt(valor));
            
            Console.WriteLine("Dobro: " + dobro);
            Console.WriteLine("Triplo: {0}", triplo);
            Console.WriteLine($"Raiz: {raiz}");
        }
    }
}



