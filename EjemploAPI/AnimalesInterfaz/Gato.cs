namespace EjemploAPI.AnimalesInterfaz
{
    public class Gato: IAnimales
    {
        public string Nombre { get; set; }
        public Gato(string nombre)
        {
            Nombre = nombre;
        }
        public string hacerRuido()
        {
            return "Miau Miau";
        }
    }
}
