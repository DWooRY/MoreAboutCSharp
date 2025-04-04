using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EmailSending
{
    class Program
    {
        static void Main(string[] args)
        {
            SendEmail("eniscanyldz_1282_@hotmail.com","Bu bir deneme emailidir.", "Deneme Emaili");
        }

        static void SendEmail(string FromWho, string Subject, string Content)
        {
            Encoding encode = Encoding.GetEncoding("windows-1254");

            MailAddress To1 = new MailAddress("eniscanyildiz@gmail.com", "Enis Can Yildiz");
            MailAddress mailFrom = new MailAddress("brcukipp@hotmail.com", "Burcu Kip", encode);
                
            MailMessage mail = new MailMessage();
            mail.To.Add(FromWho);
            mail.To.Add(To1);
            mail.From = mailFrom;
            //mail.CC.Add(""); Email alan kisi bu liste icerisinde tanimli olan kisileri gorebilir.
            //mail.Bcc.Add(""); Email alan kisi bu liste icerisinde tanimli olan kisileri goremez.
            mail.Subject = Subject;
            mail.Body = Content;
            mail.IsBodyHtml = true; // Email icerigi HTML formatinda gidecekse true, gitmeyecekse false yapin.
            


            SmtpClient smtpMail = new SmtpClient("smtp.office365.com", 587);
            smtpMail.Credentials = new System.Net.NetworkCredential("blabla@hotmail.com", "Hotmailden_alinabilen_uygulama_sifresi");
            smtpMail.EnableSsl = true;
            smtpMail.Send(mail);

            /*
             * Hotmail, gmail gibi mail platformlari 2022 itibariyle uygulama sifresi kullanmaya basladi.
             *  Artik direkt kullanici sifresi ile email gonderemiyoruz.
             *  Bunun yerine 2 alternatif cozum var.
             *      1- Uygulama Sifresi
             *      2- Graph API, OAuth2    
             *          Bu, klasik SMTP yerine modern bir REST API ile e-posta gönderimi yapmanı sağlıyor ama daha 
             *              karmaşık bir entegrasyon gerektiriyor.
             */




        }

    }
}
