namespace todosEjercicios.Clases
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Telefono { get; set; }
        public string Grado { get; set; }

        public Estudiante(int id, string nombre, int edad, string telefono, string grado)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Edad = edad;
            this.Telefono = telefono;
            this.Grado = grado;
        }
    }
}