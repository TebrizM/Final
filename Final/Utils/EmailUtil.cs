using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Final.Utils
{
    public static class EmailUtil
    {
        public async static Task SendEmailAsync(string email, string subject, string path, Dictionary<string, string> replaces)
        {
            string body = String.Empty;
            using (StreamReader streamReader = System.IO.File.OpenText(path))
            {
                body = streamReader.ReadToEnd();
            }

            foreach (var replace in replaces)
            {
                body = body.Replace(replace.Key, replace.Value);
            }
            MailMessage mail = new MailMessage();
            mail.To.Add(email);
            mail.From = new MailAddress(Constants.EmailAdress);
            mail.Subject = subject;
            string Body = body;
            mail.Body = Body;
            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential(Constants.EmailAdress, Constants.Password);
            smtp.EnableSsl = true;
            try
            {
                await smtp.SendMailAsync(mail);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
