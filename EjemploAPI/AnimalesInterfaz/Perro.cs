namespace EjemploAPI.AnimalesInterfaz
{
    public class Perro: IAnimales
    {
        public string Nombre { get; set; }
        public Perro(string nombre)
        {
            Nombre = nombre;
        }
        public string hacerRuido()
        {
            return "Guau Guau";
        }
    }
}
