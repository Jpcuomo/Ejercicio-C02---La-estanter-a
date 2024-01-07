using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Estante
    {
        private Producto[] _productos;
        private int _ubicacionEstante;

        private Estante(int capacidad)
        {
            _productos = new Producto[capacidad];
        }

        public Estante(int ubicacion, int capacidad) : this(capacidad)
        {
            _ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos 
        { 
            get 
            { 
                return _productos; 
            } 
        }

        public static string MostrarEstante(Estante estante)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Productos en el estante:");
            sb.AppendLine($"Ubicación del estante: {estante._ubicacionEstante}");
            foreach (Producto producto in estante._productos)
            {
                sb.AppendLine(Producto.MostrarProducto(producto));
                sb.AppendLine("---------------------------------------------------");
            }
            return sb.ToString();
        }

        // Sobrecarga de operador == y != para evaluar si el producto se encuentra en el estante o no
        public static bool operator ==(Estante estante, Producto producto)
        {
            return Array.IndexOf(estante.GetProductos, producto) != -1;
        }

        public static bool operator !=(Estante estante, Producto producto)
        {
            return !( estante == producto );
        }

        // Sobrecarga del operador +. Si hay lugar en el estante y el producto no se encuentra en este lo agrega
        public static bool operator +(Estante estante, Producto producto)
        {
            if (estante != producto)
            {
                for(int i = 0; i < estante._productos.Length; i++)
                {
                    if (estante._productos[i] is null)
                    {
                        estante._productos[i] = producto;
                        return true;
                    }
                }
            }
            return false;
        }

        // Sobrecarga del operador -.
        public static Estante operator -(Estante estante, Producto producto)
        {
            if(estante == producto)
            {
                for (int i = 0; i < estante._productos.Length; i++)
                {
                    if((object)producto == estante._productos[i])
                    {
                        estante._productos[i] = null;
                        break;
                    }
                }
            }
            return estante;
        }
    }
}
