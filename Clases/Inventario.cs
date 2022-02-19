namespace todosEjercicios.Clases
{
    public class Inventario
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public float precio { get; set; }
        public int existencia { get; set; }

        public Inventario(int codigoProducto, string nombreProducto, float precioProducto, int existenciaProducto)
        {
            codigo = codigoProducto;
            nombre = nombreProducto;
            precio = precioProducto;
            existencia = existenciaProducto;
        }
    }

}