using StarGames.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace StarGames.BLL
{
    public class EmailBLL
    {
        public void Enviar(EmailDTO obj)
        {
            //Configurar o Email

            MailMessage email = new MailMessage();


            //Remetente
            email.From = new MailAddress(obj.EmailRemetente, obj.NomeRemetente);

            //Destinatario
            email.To.Add(new MailAddress(obj.EmailDestinatario, obj.NomeDestinatario));

            //Assunto
            email.Subject = obj.Assunto;

            //Corpo Email
            email.Body = obj.Mensagem;

            //Confiogurar o SMTPClient
            SmtpClient smtp = new SmtpClient();

            //dados do servidor (Gmail)
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("ti01senacsmp@gmail.com", "LUgiEw6u");

            //Enviar Email
            try
            {
                smtp.Send(email);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao enviar" + ex.Message);
            }



        }

    }
}
