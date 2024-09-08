using System.Security.Cryptography.X509Certificates;

namespace Viajes_Turisticos
{
    internal class CEjecutora
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            CInterfaz interfaz = new CInterfaz();
            string description;
            float precio, impuesto;
            uint opcion,codigo;
            CPaquete paquete;
            List<CPaquete> LISTADEpaquetes= new List<CPaquete>();

            do
            {
                opcion= uint.Parse(interfaz.MostrarInfo());
                switch(opcion)
                {
                    case 1:
                         impuesto= float.Parse(interfaz.PedirDato(" El Porcentaje del Impuesto"));
                        CPaquete.impuesto = impuesto;
                        break;
                    case 2:

                        codigo = uint.Parse(interfaz.PedirDato("El Codico del paquete"));
                        description = interfaz.PedirDato("La Descripcion del paquete");
                        precio = float.Parse(interfaz.PedirDato("El Precio del paquete"));
                        paquete = new CPaquete(codigo,description, precio);
                        LISTADEpaquetes.Add(paquete);
                        break;
                    case 3:

                        codigo = uint.Parse(interfaz.PedirDato("El Codico del paquete a ELIMINAR    "));

                        foreach (CPaquete aux in LISTADEpaquetes)
                        {
                            if (aux.getCodigo() == codigo)
                            {
                                LISTADEpaquetes.Remove(aux);
                            }
                        }
                        break;
                    case 4:

                        foreach (CPaquete aux in LISTADEpaquetes)
                        {
                           Console.WriteLine(aux.mostrarDatos());
                        }

                        Console.ReadLine();
                        break;
                }


            } while (opcion!= 0);


        }
       

    }

    
}
