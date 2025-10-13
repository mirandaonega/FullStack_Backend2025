namespace EjemploAPI.EjemploInterfaz
{
    public class Base
    {
        public string Acelerar(IVehiculo vehiculo)
        {
            return vehiculo.Acelerar();
        }
    }
}
