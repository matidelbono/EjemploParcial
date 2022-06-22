using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using logica;
using static logica.Delegados;

namespace PrimerTemaParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            Ejemplo ejemplo = new Ejemplo();
            Numeros delegado1 = new Numeros(ejemplo.TipoNumero);
            Numeros delegado2 = new Numeros(Ejemplo.SignoNumero);
            Console.WriteLine("{0 } es {1 }; usar signo\"{ 2 }\".", 5, delegado1(5), delegado2(5));
            Console.WriteLine("{0 } es {1 }; usar signo\"{ 2 }\".", -3, delegado1(-3), delegado2(-3));
            Console.WriteLine("{0 } es {1 }; usar signo\"{ 2 }\".", 0, delegado1(0), delegado2(0));


        }
       
    }
}

    