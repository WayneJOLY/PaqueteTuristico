using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viajes_Turisticos
{
    internal class CPaquete//IComparable<CPaquete>
    {
        public static float impuesto;
        private uint codigo;
        private string descripcion;
        private float precio;
        

        public CPaquete(uint numero, string descripcion)
        {
            this.codigo = numero;
            this.descripcion = descripcion;
        }

        public CPaquete(uint numero, string descripcion, float precio)
        {
            this.codigo = numero;
            this.descripcion = descripcion;
            this.precio = precio;
        }

        public void setImpuesto(float impuesto)
        {
            CPaquete.impuesto = impuesto;
        }

        public void setPrecio(float precio)
        {
            this.precio=precio;
        }

        public float getPrecio() { return this.precio; }
        public uint getCodigo() {  return this.codigo; }

        public float darMontoTotal()
        {
            return precio + (precio * (impuesto / 100));
        }


        public string mostrarDatos()
        {
            return "\n Numero del¨Paquete  :"+ this.codigo +"\n Descripcion :"+ this.descripcion +"\n Precio :"+ this.precio + "\n Impuesto :"+ CPaquete.impuesto + "\n Precio Final :"+ this.darMontoTotal().ToString();
        }

        public int CompareTo(CPaquete? other)
        {
            if (other != null)
            {
                return 1;
            }

           return precio.CompareTo(other.precio);
        }
    }
}
