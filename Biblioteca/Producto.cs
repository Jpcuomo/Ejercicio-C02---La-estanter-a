using System.Text;

namespace Biblioteca
{
    public class Producto
    {
        private string _cogidoDeBarra;
        private string _marca;
        private float _precio;

        public Producto(string marca, string cogido, float precio)
        {
            _marca = marca;
            _cogidoDeBarra = cogido;
            _precio = precio;
        }

        public static string MostrarProducto(Producto producto)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Marca: {producto.GetMarca()}");
            sb.Append(" - ");
            sb.Append($"Precio: {producto.GetPrecio()}");
            sb.Append(" - ");
            sb.Append($"Código de barras: {(string)producto}");
            string cadena = sb.ToString();
            return cadena;
        }

        public string GetMarca()
        {
            return _marca; 
        }

        public float GetPrecio()
        { 
            return _precio;
        }

        // Conversión explicita de Producto a string
        public static explicit operator string(Producto producto)
        {
            return producto._cogidoDeBarra;
        }
        
        // Sobrecarga del operador == y != para comparación de Producto-Producto
        public static bool operator ==(Producto producto1, Producto producto2)
        {
            return producto1.GetMarca() == producto2.GetMarca() && producto1._cogidoDeBarra == producto2._cogidoDeBarra;
        }
        public static bool operator !=(Producto producto1, Producto producto2)
        {
            return !(producto1 == producto2);
        }

        // Sobrecarga del operador == y != para comparación de Marca y cadena (parametro)
        public static bool operator ==(Producto producto, string marca)
        {
            return (producto.GetMarca() == marca);
        }
        public static bool operator !=(Producto producto, string marca)
        {
            return !(producto == marca);
        }
    }
}
