using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPruebas
{
    public class Program
    {
        static void Main(string[] args)
        {
            serieFibonacci(10);
        }

        public static int serieFibonacci(int valor)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < valor; i++)
            {
               int auxiliar = a;
                a = b;
                b = auxiliar + a;
            }
            return a;
          

        }
    }
}
