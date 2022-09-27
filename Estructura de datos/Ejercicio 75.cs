using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Estructura_de_datos
{
    internal class Ejercicio_75
    {
        private static void main(string[] args)
        {
            string numero;

            ArrayList Lista = new ArrayList();

            Console.WriteLine("ingrese una numero en la cola");
            numero = Console.ReadLine();

            while (numero != "")
            {
                
                Console.WriteLine("Ingrese una proxima numero en la cola");
                numero = Console.ReadLine();
            }

           for (int i = 0; i < Lista.Count; i++)
            {
                int dato =(int) Lista[i];
                Console.WriteLine(dato);

            }



            {

                Console.ReadKey();



            }
        }
    }
}
