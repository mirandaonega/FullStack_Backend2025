namespace EjemploAPI.EjemploHerencia
{
    public class Auto: Vehiculo
    {
        public string NroChasis { get; set; }

        public override string Acelerar()
        {
            return "El auto aceleró.";
        }

        public override string Frenar()
        {
            return "El auto frenó.";
        }
    }
}
