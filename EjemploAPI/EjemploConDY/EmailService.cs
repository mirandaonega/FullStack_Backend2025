namespace EjemploAPI.EjemploConDY
{
    public class EmailService: IEmailService
    {
        public string EnviarMail(string email)
        {
            return "Mail enviado a " + email;
        }
    }
}
