namespace EjemploAPI.EjemploHerencia
{
    public class Vehiculo
    {
        public Vehiculo()
        { }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        private string Patente { get; set; }
        protected string Combustible { get; set; }
        public virtual string Acelerar()
        {
            return "El vehículo aceleró.";
        }
        public virtual string Frenar()
        {
            return "El vehículo frenó.";
        }
    }
}
