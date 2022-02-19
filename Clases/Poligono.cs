namespace todosEjercicios.Clases
{
    public class Poligono
    {
        public int lado;
        public int angulo;
        public int ladoPropiedad { get { return lado; } set {if (value > 0) this.lado = value; else lado = 1;} }
        public int anguloPropiedad { get {return angulo; }set {if(value>=0 && value<=90) this.angulo = value; else angulo = 1; } }
        public Poligono()
        {

        }

        public Poligono(int lados, int angulos)
        {
            this.lado = lados;
            this.angulo = angulos;
        }

        public override string ToString()
        {
            return "Numero de lados: " + lado + " " + " Angulo: " + angulo;
        }
    }
}