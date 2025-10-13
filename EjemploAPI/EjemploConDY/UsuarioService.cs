namespace EjemploAPI.EjemploConDY
{
    public class UsuarioService
    {
        private IEmailService emailService;

        //dependencia inyectada por el constructor
        public UsuarioService(IEmailService emailService)
        {
            this.emailService = emailService;
        }
        public string NotificarEnvioMail(string email)
        {
            return this.emailService.EnviarMail(email);
        }
    }
}
