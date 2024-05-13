using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica.DB.Base.Objetos
{
    class Email
    {

        public string Para { get; set; }
        public string Assunto { get; set; }
        public string Mensagem { get; set; }


        MailMessage email = new MailMessage();

        public void Enviar()
        {
            Task.Factory.StartNew(() =>
            {
                string remetente = "ltcctecnology@gmail.com";
                string senha = "infoc2018";

                email.From = new MailAddress(remetente);
                email.To.Add(this.Para);

                email.Subject = this.Assunto;
                email.Body = this.Mensagem;
                email.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;

                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(remetente, senha);

                smtp.Send(email);

            });
        }


        public void AdicionarAnexo(string arquivo)
        {
            Attachment inline = new Attachment(arquivo);
            this.email.Attachments.Add(inline);
        }
    }
}
