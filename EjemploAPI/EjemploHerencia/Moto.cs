namespace EjemploAPI.EjemploHerencia
{
    public class Moto: Vehiculo
    {
        public string TipoMoto { get; set; }
        public override string Acelerar()
        {
            return "La moto aceleró.";
        }
        public override string Frenar()
        {
            return "La moto frenó.";
        }
    }
}
