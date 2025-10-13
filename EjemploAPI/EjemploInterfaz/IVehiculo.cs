namespace EjemploAPI.EjemploInterfaz
{
    public interface IVehiculo
    {
        public string Acelerar();
        public string Frenar();
        public string ObtenerDistanciaRecorrida()
        {
            return "El vehículo recorrió 20km.";
        }
     }
 }
