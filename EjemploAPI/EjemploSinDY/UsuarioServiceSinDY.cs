namespace EjemploAPI.EjemploSinDY
{
    public class UsuarioServiceSinDY
    {
        public EmailServiceSinDY emailServiceSinDY { get; set; }
        public UsuarioServiceSinDY()
        {
            emailServiceSinDY = new EmailServiceSinDY();
            //enviar mail
        }
        public bool EnviarNotificacionUsuario(string mail)
        {
            emailServiceSinDY.Enviar(mail, "notificación");
            return true;
        }
    }
}
