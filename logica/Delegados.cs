using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
    public class Delegados
    {

        public delegate String Numeros(int Nro);

        
            public class Ejemplo
        {
          

            public int Nro { get; set; }
            public String TipoNumero(int Entero)
            {
                if (Entero > 0) return "positivo";
                if (Entero < 0) return "negativo";
                return "cero";
            }
            public static String SignoNumero(int Entero)
            {
                if (Entero > 0) return "+";
                if (Entero < 0) return "-";
                return "";
            }
           
    }
    }
}
