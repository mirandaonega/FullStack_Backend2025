namespace EjemploAPI.EjemploInterfaz
{
    public class Auto: IVehiculo
    {
        public string Acelerar()
        {
            return "El auto aceleró.";
        }
        public string Frenar()
        {
            throw new NotImplementedException();
        }
    }
}
