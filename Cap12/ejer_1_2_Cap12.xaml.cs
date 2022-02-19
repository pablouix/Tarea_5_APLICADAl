using System;
using System.Windows;
using System.Linq;
using todosEjercicios.Clases;
using System.Diagnostics;

namespace todosEjercicios.Cap12
{
    public partial class ejer_1_2_Cap12 : Window
    {
        /*
        1 Usar la depuración paso a paso para
        observar cómo cambia el valor de la
        variable en el programa del factorial.

        2 Utilizar el método WriteLine() de la clase
        Debug para que las funciones nos
        indiquen cuando entramos y salimos de
        ellas.
        */

        public ejer_1_2_Cap12()
        {
            
            InitializeComponent();
        }

        public void Click_btnAgregar(object sender, RoutedEventArgs e)
        {
            if(!Validar())
                return;
           
            TextBoxFactorial.Text = factorial(Convert.ToInt32(TextBoxNumero.Text)).ToString();
            Debug.Write("Salio de la funcion");
        }

        private void Click_btnLimpiar(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        public void Limpiar()
        {
            TextBoxNumero.Text = "";
            TextBoxFactorial.Text = "";
        }

        public bool Validar()
        {
            bool paso = false;
            if(string.IsNullOrWhiteSpace(TextBoxNumero.Text))
                MessageBox.Show("Digita un numero");
            else
                paso = true;
            return paso;
        }

        public int factorial(int n)
        {
            Debug.Write("Entro en la funcion");
            if(n==0)
                return 1;
            else
                return n * factorial(n-1);
        }
    }
}