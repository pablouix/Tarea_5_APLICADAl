using System;
using System.Windows;
using System.Linq;
using todosEjercicios.Clases;

namespace todosEjercicios.Cap10
{
    public partial class ejer1Cap10 : Window
    {
        /*
        1 Crear el diseño de una clase para llevar
        el inventario de una tienda.
        */
        public ejer1Cap10()
        {
            InitializeComponent();
        }

        public void Click_btnAgregar(object sender, RoutedEventArgs e)
        {
            if(!Validar())
                return;
            Inventario inventario = new Inventario(Convert.ToInt32(TextBoxProductoId.Text), TextBoxNombre.Text, float.Parse(TextBoxPrecio.Text), Convert.ToInt32(TextBoxExistencia.Text));
            MessageBox.Show("Articulo guardado en el inventario..");
            Limpiar();

            ListBoxProductos.Items.Add(inventario.codigo.ToString()+" "+inventario.nombre.ToString()+"  $"+inventario.precio.ToString()+" "+inventario.existencia.ToString());
        }

        private void Click_btnLimpiar(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        public void Limpiar()
        {
            TextBoxProductoId.Text = "";
            TextBoxNombre.Text = "";
            TextBoxPrecio.Text = "";
            TextBoxExistencia.Text = "";
        }

        public bool Validar()
        {
            bool paso = false;
            if(string.IsNullOrWhiteSpace(TextBoxProductoId.Text))
                MessageBox.Show("Digita el id del articulo");
            else if(string.IsNullOrWhiteSpace(TextBoxNombre.Text))
                MessageBox.Show("Digita el nombre del articulo");
            else if(string.IsNullOrWhiteSpace(TextBoxPrecio.Text))
                MessageBox.Show("Digita el precio del articulo");
            else if(string.IsNullOrWhiteSpace(TextBoxExistencia.Text))
                MessageBox.Show("Digita la existencia del articulo");
            else
                paso = true;
            return paso;
        }
    }
}