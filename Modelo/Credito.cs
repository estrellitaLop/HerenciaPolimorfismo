using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Credito : Venta
    {
        public static int x;
        public Credito()
        {
            x++;
        }
        public int GetX()
        {
            return x;
        }
        //Atributos de la clase Credito
        public int Letras { get; set; }
         // metodos de la clase Credito

        public double CalculaMontoInteres()
        {
            switch (Letras)
            {
                case 3: return 5.0 / 100 * CalculadoraSubtotal();
                case 6: return 10.0 / 100 * CalculadoraSubtotal();
                case 9: return 15.0 /100 * CalculadoraSubtotal();
                case 12: return 25.0/100* CalculadoraSubtotal();
            }
                
            return 0;
        }
        public double CalculaMontoMensual()
        {
            return (CalculadoraSubtotal() + CalculaMontoInteres()) / Letras;
        }
    }
}
