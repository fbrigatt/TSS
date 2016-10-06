using GuaraTattooSoft.Entidades;
using GuaraTattooSoft.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using GuaraTattooSoft.Threads;
using System.IO;
using System.Threading;

namespace GuaraTattooSoft.Threads
{
    class Email
    {

        public bool success = false;

        public Email()
        {

        }

        public void EnviaEmail(string sender, string senderName, string senderPasswd, string recipient, string recipientName, string subject, string body, string nomeArquivoImagem = null, bool publishResult = false)
        {
            new Thread(() =>
            {
                var client = new System.Net.Mail.SmtpClient();

                if (string.IsNullOrWhiteSpace(sender)) return;

                client.Host = ("smtp.gmail.com");
                client.Port = 587;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(sender, senderPasswd);

                MailAddress remetente = new MailAddress(sender, senderName);
                MailAddress destinatario = new MailAddress(recipient, recipientName);

                var mail = new MailMessage(remetente, destinatario);

                if (!string.IsNullOrWhiteSpace(nomeArquivoImagem))
                {
                    try
                    {
                        string pasta = Directory.GetCurrentDirectory();

                        nomeArquivoImagem = nomeArquivoImagem.Replace(" ", string.Empty);
                        string diretorio = pasta + @"\Modelos de Email\" + nomeArquivoImagem;

                        mail.Attachments.Add(new Attachment(diretorio));
                        string contentID = "imagem";
                        mail.Attachments[0].ContentId = contentID;

                        body = body.Replace("<img src=" + nomeArquivoImagem + " height =\"300\" width=\"300\">", "< img src = \"cid:" + contentID + " height = \"300\" width = \"300\" >");
                    }
                    catch (Exception ex)
                    {
                        Erro.Show(ex.Message, "Erro em EnvioEmail");
                    }
                }

                mail.Subject = subject;
                mail.Body = body.Replace("\n", "<br />");
                mail.IsBodyHtml = true;

                try
                {
                    client.Send(mail);


                    if (publishResult)
                    {
                        Sucesso.Show("O email foi enviado!");
                    }
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("O servidor SMTP requer uma conexão segura ou o cliente não foi autenticado."))
                    {
                        System.Diagnostics.Process.Start("https://www.google.com/settings/security/lesssecureapps?pli=1");
                    }

                    Erro.Show(ex.Message, "Erro ao enviar email");
                }
               
            }).Start();
        }
    }
}
