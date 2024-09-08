using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viajes_Turisticos
{
    public class CInterfaz
    {

       public  CInterfaz(){
           
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            }


        public string MostrarInfo()
        {

            Console.WriteLine(" [1] Establecer el Impuesto ");
            Console.WriteLine(" [2] Agregar un nuevo paquete ");
            Console.WriteLine(" [3] Eliminar un  paquete ");
            Console.WriteLine(" [4] Listar los paquetes paquete ");

            Console.WriteLine(" [5] Agregar un nuevo paquete ");

            Console.WriteLine(" [6] Agregar un nuevo paquete ");
            return PedirDato("La Opcion elegida");
        }


        public string PedirDato(string dato)
        {
            string info;
            Console.WriteLine($"Ingrese {dato}");
            info=Console.ReadLine();

            while (info == "") {
                Console.WriteLine($"Ingrese {dato}");
                info = Console.ReadLine();
            }

            return info;
        }
    }
}
