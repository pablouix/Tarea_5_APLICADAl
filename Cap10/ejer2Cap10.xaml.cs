using System;
using System.Windows;
using System.Linq;
using todosEjercicios.Clases;

namespace todosEjercicios.Cap10
{
    public partial class ejer2Cap10 : Window
    {
        /*
        2 Crear una clase para llevar la
        información de los estudiantes de una
        escuela.
        */
        public ejer2Cap10()
        {
            InitializeComponent();
        }

        public void Click_btnAgregar(object sender, RoutedEventArgs e)
        {
            if (!Validar())
                return;
            Estudiante estudiante = new Estudiante(Convert.ToInt32(TextBoxId.Text), TextBoxNombre.Text,  Convert.ToInt16(TextBoxEdad.Text), TextBoxTelefono.Text, TextBoxGrado.Text);
            MessageBox.Show("Estudiante agregado con exito..");
            Limpiar();

            ListBoxProductos.Items.Add(estudiante.Id.ToString()+" "+estudiante.Nombre.ToString()+" "+estudiante.Edad.ToString()+" "+estudiante.Telefono.ToString()+" "+estudiante.Grado.ToString());
        }

        private void Click_btnLimpiar(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        public void Limpiar()
        {
            TextBoxId.Text = "";
            TextBoxNombre.Text = "";
            TextBoxTelefono.Text = "";
            TextBoxEdad.Text = "";
            TextBoxGrado.Text = "";
        }

        public bool Validar()
        {
            bool paso = false;
            if (string.IsNullOrWhiteSpace(TextBoxId.Text))
                MessageBox.Show("Digita el id del estudiante");
            else if (string.IsNullOrWhiteSpace(TextBoxNombre.Text))
                MessageBox.Show("Digita el nombre del estudiante");
            else if (string.IsNullOrWhiteSpace(TextBoxTelefono.Text))
                MessageBox.Show("Digita el telefono del estudiante");
            else if (string.IsNullOrWhiteSpace(TextBoxEdad.Text))
                MessageBox.Show("Digita la edad del estudiante");
            else if (string.IsNullOrWhiteSpace(TextBoxGrado.Text))
                MessageBox.Show("Digita el grado del estudiante");
            else
                paso = true;
            return paso;
        }
    }
}