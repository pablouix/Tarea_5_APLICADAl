using System;
using System.Windows;
using System.Linq;
using todosEjercicios.Clases;

namespace todosEjercicios.Cap10
{
    public partial class ejer_3_4_5_Cap10 : Window
    {
        /*
        3 Crear una clase para polígonos con
        sobrecarga del constructor.

        4 Crear propiedades para la clase polígono
        que solamente permitan colocar valores
        válidos.

        5 Programar el método ToString() para la
        clase polígono
        */
        public ejer_3_4_5_Cap10()
        {
            InitializeComponent();
        }

        public void Click_btnAgregar(object sender, RoutedEventArgs e)
        {
            if (!Validar())
                return;
                
            Poligono poligono = new Poligono();
            poligono.ladoPropiedad = Convert.ToInt32(TextBoxLado.Text);
            poligono.anguloPropiedad = Convert.ToInt32(TextBoxAngulo.Text);

            Limpiar();
            ListBoxPoligonos.Items.Add(poligono.ToString().ToLower());
        }

        private void Click_btnLimpiar(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        public void Limpiar()
        {
            TextBoxLado.Text = "";
            TextBoxAngulo.Text = "";
        }

        public bool Validar()
        {
            bool paso = false;
            if (string.IsNullOrWhiteSpace(TextBoxLado.Text))
                MessageBox.Show("Digita el numero de lados");
            else if (string.IsNullOrWhiteSpace(TextBoxAngulo.Text))
                MessageBox.Show("Digita el angulo");
            else
                paso = true;
            return paso;
        }
    }
}